using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; //needed to connect to App.Config to get connectionstring
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver; //needed for MongoDB connection
using Dev420_RestaurantManagementSystem;

namespace Dev420_RestaurantManagementSystem
{
    public partial class LoginForm : Form
    {
        //get collection, install MongoDB.Driver, generate User Class in new file and this is the reference to the users collection in MongoDB
        IMongoCollection<User> usersCollection; 
        public LoginForm()
        {
            InitializeComponent();

            //connect to the db as soon as the form loads

            //step 1: retrieve the mongoDB connection string that was added to App.Config file 
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

            //step 2: Extract the db name from the connection string, MongoUrl is a helper from the MongoDB.Driver package 
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;

            //step 3: create a new MongoDB client using the connection string, client allows communication with MongoDB server 
            var mongoClient = new MongoClient(connectionString);

            //step 4: get the specific db from the mongoDB server
            var database = mongoClient.GetDatabase(databaseName);

            //step 5: get the "users" collection from the db, mongoDB is acase-sensitive with collection names so be careful!!
            usersCollection = database.GetCollection<User>("users"); 
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //coding the log in button: 

            //step 1: get input values from the textboxes
            string username = txb_username.Text;
            string password = txb_password.Text;

            try
            {
                // Step 2: Create a filter to match both username and password
                var filter = Builders<User>.Filter.Eq("username", username) &
                             Builders<User>.Filter.Eq("password", password);

                // Step 3: Try to find the user in the "users" collection
                var user = usersCollection.Find(filter).FirstOrDefault();

                // Step 4: If the user is found, proceed to their role-specific form
                if (user != null)
                {
                    if (user.Role == "customer")
                    {
                        var mainForm = new MainForm(user); // pass the full user object
                        mainForm.Show();
                        this.Hide();
                    }
                    else if (user.Role == "staff")
                    {
                        var mainForm = new MainForm(user);
                        mainForm.Show();
                        this.Hide(); // Only hide if successful
                    }
                    else
                    {
                        MessageBox.Show("Unknown role. Please contact support.");
                    }
                }
                else
                {
                    // If no user found, show error and keep form open
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Catch unexpected errors (e.g., database connection issue)
                MessageBox.Show("An error occurred while trying to log in:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

           
        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Creates a new object from the class called registerForm and name the variable that holds it RegisterForm.
            RegisterForm registerForm = new RegisterForm();

            //shows the form object stored in the variable registerForm
            registerForm.ShowDialog();
        }

       
    }
}
