using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;

//This form updates and displays current statuses of active orders that have not beeen served

namespace Dev420_RestaurantManagementSystem
{
    public partial class OrderTrackingForm : Form
    {
        // MongoDB collections for users and orders
        private readonly IMongoCollection<User> usersCollection;
        private readonly IMongoCollection<Order> ordersCollection;

        // Currently logged-in user
        private readonly User currentUser;

        // List of orders that need to be tracked in real-time
        private List<Order> ordersToTrack;

        // This will Indexe to track current order and its current status stage
        private int currentOrderIndex = 0;
        private int currentStatusIndex = 0;

        // The sequence of statuses an order goes through
        private readonly string[] statusSteps = { "Placed", "In Kitchen", "Ready to Serve", "Served" };
        public OrderTrackingForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            // Displays the current user's username in the corner label
            lbl_LoggedInUser.Text = $"Welcome, {user.Username}";

            // Initializes MongoDB connection
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var dbName = MongoUrl.Create(connectionString).DatabaseName;
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(dbName);

            ordersCollection = db.GetCollection<Order>("orders");
            usersCollection = db.GetCollection<User>("users");
        }
        private void OrderTrackingForm_Load(object sender, EventArgs e)
        {
            //timer tick event and loads all current unserved orders
                    orderTimer.Tick += orderTimer_Tick;
                    LoadOrders();
        }
        private async void btn_StartTracking_Click(object sender, EventArgs e)
        {
            // Gets all orders for the current user that have not yet been servedd
            ordersToTrack = await ordersCollection
                .Find(o => o.UserId == currentUser.UserID && o.Status != "Served")
                .ToListAsync();

            // Messagebox for when there are no active orders, notifies and exits
            if (ordersToTrack.Count == 0)
            {
                MessageBox.Show("No active orders to track.");
                return;
            }

            // Initializes tracking state for the first order
            currentOrderIndex = 0;
            currentStatusIndex = Array.IndexOf(statusSteps, ordersToTrack[currentOrderIndex].Status);

            // Starts timer to simulate status updates
            orderTimer.Interval = 3000; // simulates an update every 3 seconds
            orderTimer.Start();

           

        }

        private async void orderTimer_Tick(object sender, EventArgs e)
        {
            // This Stops tracking if all orders have been served
            if (currentOrderIndex >= ordersToTrack.Count)
            {
                orderTimer.Stop();
                lb_OrderStatus.Items.Add("All orders are now served.");
                return;
            }

            var currentOrder = ordersToTrack[currentOrderIndex];

            // If current status is not the final one, move to the next step
            if (currentStatusIndex < statusSteps.Length - 1)
            {
                currentStatusIndex++;
                string newStatus = statusSteps[currentStatusIndex];

                // Updates status in MongoDB
                var filter = Builders<Order>.Filter.Eq(o => o.OrderId, currentOrder.OrderId);
                var update = Builders<Order>.Update.Set(o => o.Status, newStatus);
                await ordersCollection.UpdateOneAsync(filter, update);

                // Gets username info for a better formated string to know who placed the order
                var user = await usersCollection.Find(u => u.UserID == currentOrder.UserId).FirstOrDefaultAsync();
                string username = user != null ? user.Username : "Unknown";

                // Get items
                string itemSummary = string.Join(", ",
                    currentOrder.Items.Select(i => $"{i.Name} (x{i.Quantity})"));

                // Build readable status string that'll be userfriednly insetad of reading the orderID
                string display = $"User: {username} | Ordered: {currentOrder.OrderDate.ToShortDateString()} | Items: {itemSummary} | Status: {newStatus}";

                lb_OrderStatus.Items.Add(display);
            }
            else
            {
                // Move to next order and restatrd the status
                currentOrderIndex++;
                currentStatusIndex = 0;
            }

            

        }
        private async void LoadOrders()
        {

            // Only loads orders that are not yet served
            var pendingStatuses = new[] { "Placed", "In Kitchen", "Ready to Serve" };

            var orders = await ordersCollection
                .Find(order => pendingStatuses.Contains(order.Status))
                .ToListAsync();

            lb_OrderStatus.Items.Clear();

            foreach (var order in orders)
            {
                // Lookup user info
                var user = await usersCollection
                    .Find(u => u.UserID == order.UserId)
                    .FirstOrDefaultAsync();

                string username = user != null ? user.Username : "Unknown";

                // Format order items
                string itemSummary = string.Join(", ",
                    order.Items.Select(i => $"{i.Name} (x{i.Quantity})"));

                string display = $"User: {username} | Ordered: {order.OrderDate.ToShortDateString()} | Items: {itemSummary} | Status: {order.Status}";

                lb_OrderStatus.Items.Add(display);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //close order processing from form
            this.Hide();

            //show main form system
            var mainForm = new MainForm(currentUser);

            mainForm.Show();
        }
    }
}
