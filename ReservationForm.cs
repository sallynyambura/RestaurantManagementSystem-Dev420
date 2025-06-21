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
            // Creates a new Reservation object from user input
            var reservation = new Reservation
            {
                UserId = currentUserId.UserID,
                ReservationName = txb_ReservationName.Text,
                TableNumber = int.Parse(txb_TableNumber.Text),
                ReservationDate = dtp_ReservationDate.Value,
                NumberOfPeople = (int)nup_NumberOfPeople.Value
            };

            // Inserts reservation into MongoDB
            await reservationsCollection.InsertOneAsync(reservation);

            // Confirmation message for the user
            MessageBox.Show("Table reserved!");

            // Reloads reservation list box
            LoadReservations();

        }

        // Loads all reservations for the current user logged in and displays them in the ListBox
        private async void LoadReservations()
        {
            // Gets reservations from MongoDB for user logged in
            var reservations = await reservationsCollection.Find(r => r.UserId == currentUserId.UserID).ToListAsync();

            lb_Reservations.Items.Clear(); // Clears the current display

            foreach (var r in reservations)
            {
                // Adds each reservation as this string
                lb_Reservations.Items.Add($"Name: {r.ReservationName} | Table: {r.TableNumber} | Date: {r.ReservationDate.ToShortDateString()} | People: {r.NumberOfPeople}");
            }
        }

     
        //cancel reservation click event
        private async void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Checks if an item is selected and tries to cancel it
            if (lb_Reservations.SelectedItem is Reservation selected)
            {
                // Deletes the reservation from MongoDB
                await reservationsCollection.DeleteOneAsync(r => r.ReservationId == selected.ReservationId);
                MessageBox.Show("Reservation canceled.");
                LoadReservations(); //refreshes the display
            }
            else
            {
                MessageBox.Show("Select a reservation to cancel.");
            }

        }

        
       
    }
}
