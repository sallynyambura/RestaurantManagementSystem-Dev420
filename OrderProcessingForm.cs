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
    public partial class OrderProcessingForm : Form
    {
        private User currentUserId; //declare 

        //get collection, install MongoDB.Driver, generate User Class in new file and this is the reference to the users collection in MongoDB
        IMongoCollection<MenuItem> menuItemsCollection;
        IMongoCollection<Order> ordersCollection;

        //stores the selected items for the current order
        List<ItemOrder> selectedItems = new List<ItemOrder>();
        public OrderProcessingForm( User user)
        {
            InitializeComponent();
            currentUserId = user;
        }

        private async void OrderProcessingForm_Load(object sender, EventArgs e)
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

            //step 5: get the "users" collection from the db, mongoDB is acase-sensitive with collection names so be careful!!
            menuItemsCollection = database.GetCollection<MenuItem>("menuItems");
            ordersCollection = database.GetCollection<Order>("orders");

            //step 6: Load all menu items and display them in the DataGridView
            try
            {
                var menuItems = await menuItemsCollection.Find(_ => true).ToListAsync();
                dataGridView_menuItems.DataSource = menuItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu items: " + ex.Message);
            }
        }
       

        private void btn_addToOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView_menuItems.CurrentRow != null)
            {
                //get the selected item from the table 
                var itemSelected = (MenuItem)dataGridView_menuItems.CurrentRow.DataBoundItem;

                //get quantity chosen 
                int quantityOfItem = (int)numericUpDown_quantity.Value;

                if(quantityOfItem > 0)
                {
                    //create a new order line 
                    var itemOrder = new ItemOrder
                    {
                        ItemId = itemSelected.MenuItemID,
                        Name = itemSelected.MenuItemName,
                        Quantity = quantityOfItem,
                    };

                    //Add to our order list
                    selectedItems.Add(itemOrder);

                    listBox_selectedItems.Items.Add($"{itemSelected.MenuItemName} x {quantityOfItem}");
                } else{
                    MessageBox.Show("Please enter a valid quality.");
                }

            } else
            {
                MessageBox.Show("Please select a menu item.");
            }

        }

        private async void btn_PlaceOrder_Click(object sender, EventArgs e)
        {
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("No items selected. Please add items to your order.");
                return;
            }

            //try catch to create a new order 
            try
            {
                //creare new order object 
                var newOrder = new Order
                {
                    OrderId = Guid.NewGuid().ToString(),
                    UserId = currentUserId.UserID, //will be replaced with userId when logged in
                    Items = selectedItems,
                    OrderDate = DateTime.Now,
                    Status = "Placed"
                };

                //inserting the order into the orders collection 
                await ordersCollection.InsertOneAsync(newOrder);

                MessageBox.Show("Order has been placed successfully!");

                //update status
                lbl_Status.Text = "Order Status: Placed";

                //reset the form 
                selectedItems.Clear();
                listBox_selectedItems.Items.Clear();
                numericUpDown_quantity.Value = 1;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to place order, please try again: " + ex.Message);

            }

        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            //close order processing from form
            this.Hide();

            //show main form system
            var mainForm = new MainForm(currentUserId);

            mainForm.Show();
        }
    }
}
