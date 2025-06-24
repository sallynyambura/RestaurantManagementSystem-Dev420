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
    public partial class MenuManagementForm : Form
    {
        //get collection, install MongoDB.Driver, generate MenuItem Class in new file and this is the reference to the menuItem collection in MongoDB
        private IMongoCollection<MenuItem> menuItemsCollection;
        // Currently logged-in user
        private readonly User currentUser;
        public MenuManagementForm(User user)
        {
           
            InitializeComponent();
            currentUser = user;

            // Displays the current user's username in the corner label
            lbl_LoggedInUser.Text = $"Welcome, {user.Username}";

        }
        private void MenuManagement_Load(object sender, EventArgs e)
        {
            //connect to the db as soon as the form loads

            //step 1: retrieve the mongoDB connection string that was added to App.Config file 
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

            //step 2: Extract the db name from the connection string, MongoUrl is a helper from the MongoDB.Driver package 
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;

            //step 3: create a new MongoDB client using the connection string, client allows communication with MongoDB server 
            var mongoClient = new MongoClient(connectionString);

            //step 4: get the specific db from the mongoDB server
            var database = mongoClient.GetDatabase(databaseName);

            //step 5: get the "menuItems" collection from the db, mongoDB is case-sensitive with collection names so be careful!!
            menuItemsCollection = database.GetCollection<MenuItem>("menuItems");

            //call function loadData 
            LoadMenuItemsData();

        }
    

        private void LoadMenuItemsData()
        {
            //proces of loading data on datagrid view
            //what we need to get dtat
            var filterDefinition = Builders<MenuItem>.Filter.Empty;
            //find the data that we need and convert to list
            var menuItems = menuItemsCollection.Find(filterDefinition).ToList();
            //what we will see (populate the grid view)
            dataGridView1.DataSource = menuItems;

        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            //be able to add a new book using the button 
            //create object, add it to list
            var menuItem = new MenuItem
            {
                MenuItemName = txb_menuItemName.Text,
                Description = txb_menuItemDescription.Text,
                Price = decimal.Parse(txb_menuItemPrice.Text),
                Category = txb_menuItemCategory.Text
            };
            //already mapped to db, only insert one.
            menuItemsCollection.InsertOne(menuItem);

            //refresh data grid view after adding new data 
            LoadMenuItemsData();

        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            //delete based on name of the menu item. delete based on filter quert of title. Have to type exactly. 

            var filterDefinition = Builders<MenuItem>.Filter.Eq("name", txb_menuItemName.Text);

            menuItemsCollection.DeleteOne(filterDefinition);

            //after deleting, refresh the data. not the most efficient way, but the easiest. 
            LoadMenuItemsData();

        }

        private void btn_updateItem_Click(object sender, EventArgs e)
        {
            //update also needs filter definition 
            //based on the title, we can filter the other 3. unable to actually update the title's name since it is based on the filter definition
            var filterDefinition = Builders<MenuItem>.Filter.Eq("name", txb_menuItemName.Text);

            //then we need our update defintion 
            var updateDefinition = Builders<MenuItem>.Update
                .Set("description", txb_menuItemDescription.Text)
                .Set("price", decimal.Parse(txb_menuItemPrice.Text))
                .Set("category", txb_menuItemCategory.Text);

            menuItemsCollection.UpdateOne(filterDefinition, updateDefinition);

            //load data
            LoadMenuItemsData();

        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            //sign out from staff form and go back to login page

            //close staff form
            this.Hide();

            //show loginForm 
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close order processing from form
            this.Hide();

            //show main form system
            var mainForm = new MainForm(currentUser);

            mainForm.Show();
        }
    }

        
    
}
