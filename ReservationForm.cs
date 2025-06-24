using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Dev420_RestaurantManagementSystem
{
    
    public partial class ReservationForm : Form
    {
        // Reference to the MongoDB  reservation collection
        private IMongoCollection<Reservation> reservationsCollection;

        // Stores currently logged-in user for associated reservation
        private User currentUserId;

        private List<Reservation> userReservations = new List<Reservation>();

        // Constructor receives logged-in User object
        public ReservationForm( User user)
        {
            InitializeComponent();
            currentUserId = user;
            //Displays logged-in usersname in a corner label
            lbl_LoggedInUser.Text = $"Welcome, {currentUserId.Username}";

            // Step 1: Get the MongoDB connection string from App.config
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            // Step 2: Extract database name using MongoDB helper
            var dbName = MongoUrl.Create(connectionString).DatabaseName;
            // Step 3: Connect to the MongoDB server and get the reservations collection
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(dbName);
            reservationsCollection = db.GetCollection<Reservation>("reservations");
        }

        //When the form loades, populates reservation list
        private void ReservationForm_Load_1(object sender, EventArgs e)
        {
            LoadReservations();

        }


        //Reserve button click event
        private async void btn_Reserve_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate required fields before doing anything
                if (string.IsNullOrWhiteSpace(txb_ReservationName.Text) ||
                    string.IsNullOrWhiteSpace(txb_TableNumber.Text) ||
                    nup_NumberOfPeople.Value <= 0)
                {
                    MessageBox.Show("Please fill out all fields and enter a number of people.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 2: Try to parse table number safely
                if (!int.TryParse(txb_TableNumber.Text, out int tableNumber))
                {
                    MessageBox.Show("Please enter a number for the table, and please do not use text.", "Invalid Table Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 3: Create and insert reservation
                var reservation = new Reservation
                {
                    UserId = currentUserId.UserID,
                    ReservationName = txb_ReservationName.Text,
                    TableNumber = tableNumber,
                    ReservationDate = dtp_ReservationDate.Value, // Make sure this picker exists and is configured properly
                    NumberOfPeople = (int)nup_NumberOfPeople.Value
                };

                await reservationsCollection.InsertOneAsync(reservation);

                MessageBox.Show("Table has been reserved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Step 4: Refresh list and clear form if needed
                LoadReservations(); // Reloads reservation list box
                txb_ReservationName.Clear();
                txb_TableNumber.Clear();
                nup_NumberOfPeople.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reserving a table.\nDetails: {ex.Message}", "Error, Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Loads all reservations for the current user logged in and displays them in the ListBox
        private async void LoadReservations()
        { 
            // Gets reservations from MongoDB for user logged in
            userReservations = await reservationsCollection.Find(r => r.UserId == currentUserId.UserID).ToListAsync();

            lb_Reservations.Items.Clear(); // Clears the current display

            foreach (var r in userReservations)
            {
                // Adds each reservation as this string
                lb_Reservations.Items.Add(
                    $"Name: {r.ReservationName} | Table: {r.TableNumber} | Date: {r.ReservationDate:MM/dd/yyyy hh:mm tt} | People: {r.NumberOfPeople}"
                );
            }



        }


        //cancel reservation click event
        private async void btn_Cancel_Click(object sender, EventArgs e)
        {
           
            // Checks if an item is selected and tries to cancel it
            if (lb_Reservations.SelectedIndex >= 0)
            {
                var selectedReservation = userReservations[lb_Reservations.SelectedIndex];

                // Deletes the reservation from MongoDB
                await reservationsCollection.DeleteOneAsync(r => r.ReservationId == selectedReservation.ReservationId);

                MessageBox.Show("Reservation canceled.");
                LoadReservations(); //refreshes the display
            }
            else
            {
                MessageBox.Show("Select a reservation to cancel.");
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
}
