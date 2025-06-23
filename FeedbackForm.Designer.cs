namespace Dev420_RestaurantManagementSystem
{
    partial class FeedbackForm
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
            this.txb_Comment = new System.Windows.Forms.TextBox();
            this.nup_Rating = new System.Windows.Forms.NumericUpDown();
            this.btn_SubmitFeedback = new System.Windows.Forms.Button();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_LoggedInUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_PastOrders = new System.Windows.Forms.ComboBox();
            this.lb_Feedback = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Comment
            // 
            this.txb_Comment.Location = new System.Drawing.Point(355, 177);
            this.txb_Comment.Multiline = true;
            this.txb_Comment.Name = "txb_Comment";
            this.txb_Comment.Size = new System.Drawing.Size(265, 59);
            this.txb_Comment.TabIndex = 0;
            // 
            // nup_Rating
            // 
            this.nup_Rating.Location = new System.Drawing.Point(355, 139);
            this.nup_Rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nup_Rating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_Rating.Name = "nup_Rating";
            this.nup_Rating.Size = new System.Drawing.Size(265, 22);
            this.nup_Rating.TabIndex = 1;
            this.nup_Rating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_SubmitFeedback
            // 
            this.btn_SubmitFeedback.Location = new System.Drawing.Point(483, 261);
            this.btn_SubmitFeedback.Name = "btn_SubmitFeedback";
            this.btn_SubmitFeedback.Size = new System.Drawing.Size(137, 26);
            this.btn_SubmitFeedback.TabIndex = 2;
            this.btn_SubmitFeedback.Text = "Submit Feedback";
            this.btn_SubmitFeedback.UseVisualStyleBackColor = true;
            this.btn_SubmitFeedback.Click += new System.EventHandler(this.btn_SubmitFeedback_Click);
            // 
            // lbl_comment
            // 
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Location = new System.Drawing.Point(55, 220);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(135, 16);
            this.lbl_comment.TabIndex = 4;
            this.lbl_comment.Text = "Please add more info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order";
            // 
            // lbl_LoggedInUser
            // 
            this.lbl_LoggedInUser.AutoSize = true;
            this.lbl_LoggedInUser.Location = new System.Drawing.Point(426, 30);
            this.lbl_LoggedInUser.Name = "lbl_LoggedInUser";
            this.lbl_LoggedInUser.Size = new System.Drawing.Size(102, 16);
            this.lbl_LoggedInUser.TabIndex = 5;
            this.lbl_LoggedInUser.Text = "Logged In User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rating ";
            // 
            // cmb_PastOrders
            // 
            this.cmb_PastOrders.FormattingEnabled = true;
            this.cmb_PastOrders.Location = new System.Drawing.Point(355, 95);
            this.cmb_PastOrders.Name = "cmb_PastOrders";
            this.cmb_PastOrders.Size = new System.Drawing.Size(265, 24);
            this.cmb_PastOrders.TabIndex = 7;
            // 
            // lb_Feedback
            // 
            this.lb_Feedback.FormattingEnabled = true;
            this.lb_Feedback.ItemHeight = 16;
            this.lb_Feedback.Location = new System.Drawing.Point(58, 304);
            this.lb_Feedback.Name = "lb_Feedback";
            this.lb_Feedback.Size = new System.Drawing.Size(562, 196);
            this.lb_Feedback.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Feedback form: ";
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Feedback);
            this.Controls.Add(this.cmb_PastOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_LoggedInUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_comment);
            this.Controls.Add(this.btn_SubmitFeedback);
            this.Controls.Add(this.nup_Rating);
            this.Controls.Add(this.txb_Comment);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_Rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Comment;
        private System.Windows.Forms.NumericUpDown nup_Rating;
        private System.Windows.Forms.Button btn_SubmitFeedback;
        private System.Windows.Forms.Label lbl_comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_LoggedInUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_PastOrders;
        private System.Windows.Forms.ListBox lb_Feedback;
        private System.Windows.Forms.Label label3;
    }
}