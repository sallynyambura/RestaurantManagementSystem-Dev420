namespace Dev420_RestaurantManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_menu_management = new System.Windows.Forms.Button();
            this.btn_order_processing = new System.Windows.Forms.Button();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.btn_reservations = new System.Windows.Forms.Button();
            this.btn_order_tracking = new System.Windows.Forms.Button();
            this.btn_signout = new System.Windows.Forms.Button();
            this.lbl_LoggedInUser = new System.Windows.Forms.Label();
            this.lbl_RoleInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Management System";
            // 
            // btn_menu_management
            // 
            this.btn_menu_management.Location = new System.Drawing.Point(402, 261);
            this.btn_menu_management.Name = "btn_menu_management";
            this.btn_menu_management.Size = new System.Drawing.Size(158, 46);
            this.btn_menu_management.TabIndex = 1;
            this.btn_menu_management.Text = "Menu Management";
            this.btn_menu_management.UseVisualStyleBackColor = true;
            this.btn_menu_management.Click += new System.EventHandler(this.btn_menu_management_Click);
            // 
            // btn_order_processing
            // 
            this.btn_order_processing.Location = new System.Drawing.Point(304, 175);
            this.btn_order_processing.Name = "btn_order_processing";
            this.btn_order_processing.Size = new System.Drawing.Size(147, 46);
            this.btn_order_processing.TabIndex = 1;
            this.btn_order_processing.Text = "Order Processing";
            this.btn_order_processing.UseVisualStyleBackColor = true;
            this.btn_order_processing.Click += new System.EventHandler(this.btn_order_processing_Click);
            // 
            // btn_feedback
            // 
            this.btn_feedback.Location = new System.Drawing.Point(495, 175);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(147, 46);
            this.btn_feedback.TabIndex = 1;
            this.btn_feedback.Text = "Feedback";
            this.btn_feedback.UseVisualStyleBackColor = true;
            this.btn_feedback.Click += new System.EventHandler(this.btn_feedback_Click);
            // 
            // btn_reservations
            // 
            this.btn_reservations.Location = new System.Drawing.Point(90, 175);
            this.btn_reservations.Name = "btn_reservations";
            this.btn_reservations.Size = new System.Drawing.Size(158, 46);
            this.btn_reservations.TabIndex = 1;
            this.btn_reservations.Text = "Reservations";
            this.btn_reservations.UseVisualStyleBackColor = true;
            this.btn_reservations.Click += new System.EventHandler(this.btn_reservations_Click);
            // 
            // btn_order_tracking
            // 
            this.btn_order_tracking.Location = new System.Drawing.Point(206, 261);
            this.btn_order_tracking.Name = "btn_order_tracking";
            this.btn_order_tracking.Size = new System.Drawing.Size(142, 46);
            this.btn_order_tracking.TabIndex = 1;
            this.btn_order_tracking.Text = "Order Tracking";
            this.btn_order_tracking.UseVisualStyleBackColor = true;
            this.btn_order_tracking.Click += new System.EventHandler(this.btn_order_tracking_Click);
            // 
            // btn_signout
            // 
            this.btn_signout.Location = new System.Drawing.Point(577, 32);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(92, 51);
            this.btn_signout.TabIndex = 2;
            this.btn_signout.Text = "Sign Out";
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // lbl_LoggedInUser
            // 
            this.lbl_LoggedInUser.AutoSize = true;
            this.lbl_LoggedInUser.Location = new System.Drawing.Point(374, 51);
            this.lbl_LoggedInUser.Name = "lbl_LoggedInUser";
            this.lbl_LoggedInUser.Size = new System.Drawing.Size(105, 16);
            this.lbl_LoggedInUser.TabIndex = 3;
            this.lbl_LoggedInUser.Text = "Logged In User: ";
            // 
            // lbl_RoleInfo
            // 
            this.lbl_RoleInfo.AutoSize = true;
            this.lbl_RoleInfo.Location = new System.Drawing.Point(376, 76);
            this.lbl_RoleInfo.Name = "lbl_RoleInfo";
            this.lbl_RoleInfo.Size = new System.Drawing.Size(42, 16);
            this.lbl_RoleInfo.TabIndex = 4;
            this.lbl_RoleInfo.Text = "Role: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 440);
            this.Controls.Add(this.lbl_RoleInfo);
            this.Controls.Add(this.lbl_LoggedInUser);
            this.Controls.Add(this.btn_signout);
            this.Controls.Add(this.btn_order_tracking);
            this.Controls.Add(this.btn_reservations);
            this.Controls.Add(this.btn_feedback);
            this.Controls.Add(this.btn_order_processing);
            this.Controls.Add(this.btn_menu_management);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_menu_management;
        private System.Windows.Forms.Button btn_order_processing;
        private System.Windows.Forms.Button btn_feedback;
        private System.Windows.Forms.Button btn_reservations;
        private System.Windows.Forms.Button btn_order_tracking;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Label lbl_LoggedInUser;
        private System.Windows.Forms.Label lbl_RoleInfo;
    }
}

