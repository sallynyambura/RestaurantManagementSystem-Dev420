namespace Dev420_RestaurantManagementSystem
{
    partial class MenuManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txb_menuItemName = new System.Windows.Forms.TextBox();
            this.txb_menuItemDescription = new System.Windows.Forms.TextBox();
            this.txb_menuItemPrice = new System.Windows.Forms.TextBox();
            this.txb_menuItemCategory = new System.Windows.Forms.TextBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.btn_updateItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_signout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_LoggedInUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(73, 292);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // txb_menuItemName
            // 
            this.txb_menuItemName.Location = new System.Drawing.Point(264, 115);
            this.txb_menuItemName.Name = "txb_menuItemName";
            this.txb_menuItemName.Size = new System.Drawing.Size(195, 22);
            this.txb_menuItemName.TabIndex = 1;
            // 
            // txb_menuItemDescription
            // 
            this.txb_menuItemDescription.Location = new System.Drawing.Point(264, 152);
            this.txb_menuItemDescription.Name = "txb_menuItemDescription";
            this.txb_menuItemDescription.Size = new System.Drawing.Size(195, 22);
            this.txb_menuItemDescription.TabIndex = 1;
            // 
            // txb_menuItemPrice
            // 
            this.txb_menuItemPrice.Location = new System.Drawing.Point(264, 187);
            this.txb_menuItemPrice.Name = "txb_menuItemPrice";
            this.txb_menuItemPrice.Size = new System.Drawing.Size(195, 22);
            this.txb_menuItemPrice.TabIndex = 1;
            // 
            // txb_menuItemCategory
            // 
            this.txb_menuItemCategory.Location = new System.Drawing.Point(264, 227);
            this.txb_menuItemCategory.Name = "txb_menuItemCategory";
            this.txb_menuItemCategory.Size = new System.Drawing.Size(195, 22);
            this.txb_menuItemCategory.TabIndex = 1;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(505, 115);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(158, 25);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add New Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(505, 146);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(158, 25);
            this.btn_deleteItem.TabIndex = 2;
            this.btn_deleteItem.Text = "Delete Menu Item";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // btn_updateItem
            // 
            this.btn_updateItem.Location = new System.Drawing.Point(505, 177);
            this.btn_updateItem.Name = "btn_updateItem";
            this.btn_updateItem.Size = new System.Drawing.Size(158, 25);
            this.btn_updateItem.TabIndex = 2;
            this.btn_updateItem.Text = "Update Menu Item";
            this.btn_updateItem.UseVisualStyleBackColor = true;
            this.btn_updateItem.Click += new System.EventHandler(this.btn_updateItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu Item Description ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menu Item Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Menu Item Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Menu Management: ";
            // 
            // btn_signout
            // 
            this.btn_signout.Location = new System.Drawing.Point(588, 45);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(158, 25);
            this.btn_signout.TabIndex = 2;
            this.btn_signout.Text = "Sign Out";
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_LoggedInUser
            // 
            this.lbl_LoggedInUser.AutoSize = true;
            this.lbl_LoggedInUser.Location = new System.Drawing.Point(441, 29);
            this.lbl_LoggedInUser.Name = "lbl_LoggedInUser";
            this.lbl_LoggedInUser.Size = new System.Drawing.Size(105, 16);
            this.lbl_LoggedInUser.TabIndex = 5;
            this.lbl_LoggedInUser.Text = "Logged In User: ";
            // 
            // MenuManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 508);
            this.Controls.Add(this.lbl_LoggedInUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_updateItem);
            this.Controls.Add(this.btn_deleteItem);
            this.Controls.Add(this.btn_signout);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.txb_menuItemCategory);
            this.Controls.Add(this.txb_menuItemPrice);
            this.Controls.Add(this.txb_menuItemDescription);
            this.Controls.Add(this.txb_menuItemName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MenuManagementForm";
            this.Text = "MenuManagement";
            this.Load += new System.EventHandler(this.MenuManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txb_menuItemName;
        private System.Windows.Forms.TextBox txb_menuItemDescription;
        private System.Windows.Forms.TextBox txb_menuItemPrice;
        private System.Windows.Forms.TextBox txb_menuItemCategory;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_deleteItem;
        private System.Windows.Forms.Button btn_updateItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_LoggedInUser;
    }
}