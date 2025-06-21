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

            //step 2: create a filter to match both username and password, using AND logical statement to ensure both fields will match
            var filter = Builders<User>.Filter.Eq("username", username) &
                Builders<User>.Filter.Eq("password", password);

            //step3: try to find the user in the "user's" collection
            var user = usersCollection.Find(filter).FirstOrDefault();

            //step 4: if the user is found, log them in and then redirect based on the role 
            if (user != null)
            {
                // Pass the logged-in userId to the next form
                string UserId = user.UserID;

                if (user.Role == "staff")
                {
                    MainForm MainForm = new MainForm(user.UserID);
                    MainForm.Show();
                } else if(user.Role == "customer")
                {
                    MainForm MainForm = new MainForm(user.UserID);
                    MainForm.Show();
                }
                else
                {
                    MessageBox.Show("invalid username or password, error, please try again or register.");
                }

            }

            //hide login form 
            this.Hide();
            

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
