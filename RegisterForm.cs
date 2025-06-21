using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Dev420_RestaurantManagementSystem
{
    public partial class RegisterForm : Form
    {
        private IMongoCollection<User> usersCollection;
        public RegisterForm()
        {
            InitializeComponent();

            // Set up MongoDB connection once the form loads
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            usersCollection = database.GetCollection<User>("users");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txb_username.Text.Trim();
            string password = txb_password.Text.Trim();
            string email = txb_email.Text.Trim();
            string role = txb_role.Text.ToLower(); //lowercase for comparison

            //validate input to make sure all fields are completed
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            //validate role that has been inputed 
            if (role != "staff" && role != "customer")
            {
                MessageBox.Show("Role must be either 'Staff' or 'Customer' (case-insensitive).");
                return;
            }

            // Check if user already exists
            var existingUser = usersCollection.Find(u => u.Username == username).FirstOrDefault();

            if (existingUser == null)
            {
                var newUser = new User
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Role = role
                };

                usersCollection.InsertOne(newUser);

                //successful message shown as well as redirection back to login page 
                MessageBox.Show("Registration successful! You will be redirected to the Login page.");
                
                //close registration form 
                this.Hide();

                //show loginForm 
                LoginForm loginForm = new LoginForm();
                loginForm.Show();



            }
            else
            {
                MessageBox.Show("Username already taken. Please choose a different one.");
            }

        }

     
    }
}
