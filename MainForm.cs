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
    public partial class MainForm : Form
    {
        private User currentUserId;
        
        public MainForm( User user)
        {
            InitializeComponent();
            currentUserId = user;
            
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

        private void btn_menu_management_Click(object sender, EventArgs e)
        {
            //close staff form
            this.Hide();

            //show menu management system
            var menuForm = new MenuManagement();

            menuForm.Show();

        }

        private void btn_order_processing_Click(object sender, EventArgs e)
        {
            //close staff form
            this.Hide();

            //show menu management system
            var orderProcessingForm = new OrderProcessingForm(currentUserId);

            orderProcessingForm.Show();


        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            //close main
            this.Hide();

            //Reservation Form
            var reservationForm = new ReservationForm(currentUserId);

            reservationForm.Show();

        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            //close main
            this.Hide();

            // Show Feedback Form
            var feedbackForm = new FeedbackForm(currentUserId);

            feedbackForm.Show();

        }
    }
}
