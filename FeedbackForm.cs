using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;


namespace Dev420_RestaurantManagementSystem
{
    public partial class FeedbackForm : Form
    {
        // MongoDB collections for accessing orders and feedback documents
        private readonly IMongoCollection<Order> ordersCollection;
        private readonly IMongoCollection<Feedback> feedbackCollection;
        // Stores currently logged-in user for associated feedback
        private readonly User currentUserId;


        public FeedbackForm(User user)
        {
            InitializeComponent();
            // Stores logged-in user's info for reference
            currentUserId = user;
            //Displays logged-in usersname in a corner label
            lbl_LoggedInUser.Text = $"Welcome, {currentUserId.Username}";

            // Connect to the MongoDB database using the connection string from App.config
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var dbName = MongoUrl.Create(connectionString).DatabaseName;
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(dbName);

            // Get orders and feedback collections
            ordersCollection = db.GetCollection<Order>("orders");
            feedbackCollection = db.GetCollection<Feedback>("feedback");

            LoadUserOrders(); // Load user's orders into the dropdown
            LoadFeedback(); //existing feedback 
        }

        //Loads current user's past orders into the ComboBox so they can select which one to give feedback on.
        private async void LoadUserOrders()
        {
            // Query all orders that belong to the current user
            var userOrders = await ordersCollection
                .Find(o => o.UserId == currentUserId.UserID)
                .ToListAsync();

            // Clear previous items
            cmb_PastOrders.Items.Clear();

            foreach (var order in userOrders)
            {
                // Create user readable string like "Pad Thai (x1), Spring Rolls (x2) - June 11"
                string itemSummary = string.Join(", ",
                    order.Items.Select(i => $"{i.Name} (x{i.Quantity})"));

                // Create display string with items and order date
                string displayText = $"{itemSummary} — {order.OrderDate.ToShortDateString()}";

                // Add the order summary to the ComboBox as a ComboBoxItem
                cmb_PastOrders.Items.Add(new ComboBoxItem
                {
                    Display = displayText,
                    Value = order.OrderId
                });
            }

            // Tells ComboBox to show the Display property, and store the Value property
            cmb_PastOrders.DisplayMember = "Display";
            cmb_PastOrders.ValueMember = "Value";
        }

        //Loads and displays previously submitted feedback for user logged in.
        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            LoadFeedback();

        }


        //Submits new feedback to the database for the selected order.
        private async void btn_SubmitFeedback_Click(object sender, EventArgs e)
        {
            // Makes sure the user selected an order
            if (cmb_PastOrders.SelectedItem is ComboBoxItem selectedOrder)
            {
                //Create a new Feedback document with the user's input
                var feedback = new Feedback
                {
                    OrderId = selectedOrder.Value, // This is the OrderId
                    Rating = (int)nup_Rating.Value,
                    Comment = txb_Comment.Text,
                   
                    UserId = currentUserId.UserID
                };

                // Save feedback to MongoDB
                await feedbackCollection.InsertOneAsync(feedback);
                MessageBox.Show("Thanks for your feedback!");
            }
            else
            {
                MessageBox.Show("Please select an order to rate.");
            }
            LoadFeedback();  // Refresh the grid
        }

        private async void LoadFeedback()
        {
            // Get all feedbacks for logged in user
            var feedbacks = await feedbackCollection.Find(f => f.UserId == currentUserId.UserID).ToListAsync();

            // Clear the listbox before refilling
            lb_Feedback.Items.Clear();

            foreach (var fb in feedbacks)
            {
                // Gets order associated with this feedback (to show items)
                var order = await ordersCollection.Find(o => o.OrderId == fb.OrderId).FirstOrDefaultAsync();

                string orderItemsSummary = "(Unknown Order)";

                if (order != null)
                {
                    // Formats items in the order as a readable string
                    orderItemsSummary = string.Join(", ",
                        order.Items.Select(i => $"{i.Name} (x{i.Quantity})"));
                }

                // builds Format feedback as a readable string
                string display = $"Order: {orderItemsSummary} | Rating: {fb.Rating} | \"{fb.Comment}\"";

                // Adds to the feedback list
                lb_Feedback.Items.Add(display);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //close order processing from form
            this.Hide();

            //show main form system
            var mainForm = new MainForm(currentUserId);

            mainForm.Show();
        }
    }

    //ComboBox display logic so that it can pair readable text with a hidden value(OrderId).

    internal class ComboBoxItem
    {
        public string Display { get; set; } //what the user will see
        public string Value { get; set; } //order id

        public override string ToString()
        {
            return Display;
        }
    }
}
