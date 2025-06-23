namespace Dev420_RestaurantManagementSystem
{
    partial class ReservationForm
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
            this.lbl_TableNumber = new System.Windows.Forms.Label();
            this.lbl_People = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.txb_TableNumber = new System.Windows.Forms.TextBox();
            this.dtp_ReservationDate = new System.Windows.Forms.DateTimePicker();
            this.nup_NumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_Reservations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_LoggedInUser = new System.Windows.Forms.Label();
            this.lbl_ReservationName = new System.Windows.Forms.Label();
            this.txb_ReservationName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_NumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TableNumber
            // 
            this.lbl_TableNumber.AutoSize = true;
            this.lbl_TableNumber.Location = new System.Drawing.Point(126, 140);
            this.lbl_TableNumber.Name = "lbl_TableNumber";
            this.lbl_TableNumber.Size = new System.Drawing.Size(94, 16);
            this.lbl_TableNumber.TabIndex = 0;
            this.lbl_TableNumber.Text = "Table Number";
            // 
            // lbl_People
            // 
            this.lbl_People.AutoSize = true;
            this.lbl_People.Location = new System.Drawing.Point(126, 182);
            this.lbl_People.Name = "lbl_People";
            this.lbl_People.Size = new System.Drawing.Size(116, 16);
            this.lbl_People.TabIndex = 1;
            this.lbl_People.Text = "Number of People";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(126, 220);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(172, 16);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Reservation Date and Time";
            // 
            // txb_TableNumber
            // 
            this.txb_TableNumber.Location = new System.Drawing.Point(350, 134);
            this.txb_TableNumber.Name = "txb_TableNumber";
            this.txb_TableNumber.Size = new System.Drawing.Size(251, 22);
            this.txb_TableNumber.TabIndex = 2;
            // 
            // dtp_ReservationDate
            // 
            this.dtp_ReservationDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtp_ReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ReservationDate.Location = new System.Drawing.Point(350, 215);
            this.dtp_ReservationDate.Name = "dtp_ReservationDate";
            this.dtp_ReservationDate.Size = new System.Drawing.Size(321, 22);
            this.dtp_ReservationDate.TabIndex = 3;
            // 
            // nup_NumberOfPeople
            // 
            this.nup_NumberOfPeople.Location = new System.Drawing.Point(350, 176);
            this.nup_NumberOfPeople.Name = "nup_NumberOfPeople";
            this.nup_NumberOfPeople.Size = new System.Drawing.Size(251, 22);
            this.nup_NumberOfPeople.TabIndex = 4;
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Location = new System.Drawing.Point(607, 253);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(143, 26);
            this.btn_Reserve.TabIndex = 5;
            this.btn_Reserve.Text = "Reserve";
            this.btn_Reserve.UseVisualStyleBackColor = true;
            this.btn_Reserve.Click += new System.EventHandler(this.btn_Reserve_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(607, 300);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(143, 26);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel Reservation";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lb_Reservations
            // 
            this.lb_Reservations.FormattingEnabled = true;
            this.lb_Reservations.ItemHeight = 16;
            this.lb_Reservations.Location = new System.Drawing.Point(129, 253);
            this.lb_Reservations.Name = "lb_Reservations";
            this.lb_Reservations.Size = new System.Drawing.Size(472, 148);
            this.lb_Reservations.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reservation Form";
            // 
            // lbl_LoggedInUser
            // 
            this.lbl_LoggedInUser.AutoSize = true;
            this.lbl_LoggedInUser.Location = new System.Drawing.Point(604, 40);
            this.lbl_LoggedInUser.Name = "lbl_LoggedInUser";
            this.lbl_LoggedInUser.Size = new System.Drawing.Size(105, 16);
            this.lbl_LoggedInUser.TabIndex = 8;
            this.lbl_LoggedInUser.Text = "Logged In User: ";
          
            // 
            // lbl_ReservationName
            // 
            this.lbl_ReservationName.AutoSize = true;
            this.lbl_ReservationName.Location = new System.Drawing.Point(126, 98);
            this.lbl_ReservationName.Name = "lbl_ReservationName";
            this.lbl_ReservationName.Size = new System.Drawing.Size(134, 16);
            this.lbl_ReservationName.TabIndex = 9;
            this.lbl_ReservationName.Text = "Name of Reservation";
            // 
            // txb_ReservationName
            // 
            this.txb_ReservationName.Location = new System.Drawing.Point(350, 92);
            this.txb_ReservationName.Name = "txb_ReservationName";
            this.txb_ReservationName.Size = new System.Drawing.Size(251, 22);
            this.txb_ReservationName.TabIndex = 10;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.txb_ReservationName);
            this.Controls.Add(this.lbl_ReservationName);
            this.Controls.Add(this.lbl_LoggedInUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Reservations);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.nup_NumberOfPeople);
            this.Controls.Add(this.dtp_ReservationDate);
            this.Controls.Add(this.txb_TableNumber);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_People);
            this.Controls.Add(this.lbl_TableNumber);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nup_NumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TableNumber;
        private System.Windows.Forms.Label lbl_People;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox txb_TableNumber;
        private System.Windows.Forms.DateTimePicker dtp_ReservationDate;
        private System.Windows.Forms.NumericUpDown nup_NumberOfPeople;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ListBox lb_Reservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_LoggedInUser;
        private System.Windows.Forms.Label lbl_ReservationName;
        private System.Windows.Forms.TextBox txb_ReservationName;
    }
}