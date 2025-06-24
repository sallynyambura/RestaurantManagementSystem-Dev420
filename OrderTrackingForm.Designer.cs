namespace Dev420_RestaurantManagementSystem
{
    partial class OrderTrackingForm
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
            this.components = new System.ComponentModel.Container();
            this.lb_OrderStatus = new System.Windows.Forms.ListBox();
            this.btn_StartTracking = new System.Windows.Forms.Button();
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_LoggedInUser = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_OrderStatus
            // 
            this.lb_OrderStatus.FormattingEnabled = true;
            this.lb_OrderStatus.ItemHeight = 16;
            this.lb_OrderStatus.Location = new System.Drawing.Point(31, 176);
            this.lb_OrderStatus.MultiColumn = true;
            this.lb_OrderStatus.Name = "lb_OrderStatus";
            this.lb_OrderStatus.Size = new System.Drawing.Size(906, 228);
            this.lb_OrderStatus.TabIndex = 0;
            // 
            // btn_StartTracking
            // 
            this.btn_StartTracking.Location = new System.Drawing.Point(806, 121);
            this.btn_StartTracking.Name = "btn_StartTracking";
            this.btn_StartTracking.Size = new System.Drawing.Size(131, 34);
            this.btn_StartTracking.TabIndex = 1;
            this.btn_StartTracking.Text = "Start Tracking...";
            this.btn_StartTracking.UseVisualStyleBackColor = true;
            this.btn_StartTracking.Click += new System.EventHandler(this.btn_StartTracking_Click);
            // 
            // orderTimer
            // 
            this.orderTimer.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // lbl_LoggedInUser
            // 
            this.lbl_LoggedInUser.AutoSize = true;
            this.lbl_LoggedInUser.Location = new System.Drawing.Point(509, 32);
            this.lbl_LoggedInUser.Name = "lbl_LoggedInUser";
            this.lbl_LoggedInUser.Size = new System.Drawing.Size(102, 16);
            this.lbl_LoggedInUser.TabIndex = 2;
            this.lbl_LoggedInUser.Text = "Logged In User:";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(353, 83);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(258, 29);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "Order Tracking Form";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(806, 32);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 28);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // OrderTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_LoggedInUser);
            this.Controls.Add(this.btn_StartTracking);
            this.Controls.Add(this.lb_OrderStatus);
            this.Name = "OrderTrackingForm";
            this.Text = "OrderTrackingForm";
            this.Load += new System.EventHandler(this.OrderTrackingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_OrderStatus;
        private System.Windows.Forms.Button btn_StartTracking;
        private System.Windows.Forms.Timer orderTimer;
        private System.Windows.Forms.Label lbl_LoggedInUser;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_Back;
    }
}