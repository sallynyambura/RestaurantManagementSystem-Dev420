namespace Dev420_RestaurantManagementSystem
{
    partial class OrderProcessingForm
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
            this.dataGridView_menuItems = new System.Windows.Forms.DataGridView();
            this.btn_addToOrder = new System.Windows.Forms.Button();
            this.btn_PlaceOrder = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.orderStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.listBox_selectedItems = new System.Windows.Forms.ListBox();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_menuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_menuItems
            // 
            this.dataGridView_menuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_menuItems.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_menuItems.Name = "dataGridView_menuItems";
            this.dataGridView_menuItems.RowHeadersWidth = 51;
            this.dataGridView_menuItems.RowTemplate.Height = 24;
            this.dataGridView_menuItems.Size = new System.Drawing.Size(545, 272);
            this.dataGridView_menuItems.TabIndex = 0;
            // 
            // btn_addToOrder
            // 
            this.btn_addToOrder.Location = new System.Drawing.Point(581, 62);
            this.btn_addToOrder.Name = "btn_addToOrder";
            this.btn_addToOrder.Size = new System.Drawing.Size(120, 30);
            this.btn_addToOrder.TabIndex = 1;
            this.btn_addToOrder.Text = "Add to Order";
            this.btn_addToOrder.UseVisualStyleBackColor = true;
            this.btn_addToOrder.Click += new System.EventHandler(this.btn_addToOrder_Click);
            // 
            // btn_PlaceOrder
            // 
            this.btn_PlaceOrder.Location = new System.Drawing.Point(581, 269);
            this.btn_PlaceOrder.Name = "btn_PlaceOrder";
            this.btn_PlaceOrder.Size = new System.Drawing.Size(116, 28);
            this.btn_PlaceOrder.TabIndex = 2;
            this.btn_PlaceOrder.Text = "Place Order";
            this.btn_PlaceOrder.UseVisualStyleBackColor = true;
            this.btn_PlaceOrder.Click += new System.EventHandler(this.btn_PlaceOrder_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(577, 318);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(50, 16);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.Text = "Status: ";
            // 
            // listBox_selectedItems
            // 
            this.listBox_selectedItems.FormattingEnabled = true;
            this.listBox_selectedItems.ItemHeight = 16;
            this.listBox_selectedItems.Location = new System.Drawing.Point(581, 148);
            this.listBox_selectedItems.Name = "listBox_selectedItems";
            this.listBox_selectedItems.Size = new System.Drawing.Size(234, 100);
            this.listBox_selectedItems.TabIndex = 4;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(700, 12);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_quantity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Selected Order Items: ";
            // 
            // btn_goBack
            // 
            this.btn_goBack.Location = new System.Drawing.Point(580, 379);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(114, 39);
            this.btn_goBack.TabIndex = 7;
            this.btn_goBack.Text = "Back";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantity: ";
            // 
            // OrderProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_quantity);
            this.Controls.Add(this.listBox_selectedItems);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_PlaceOrder);
            this.Controls.Add(this.btn_addToOrder);
            this.Controls.Add(this.dataGridView_menuItems);
            this.Name = "OrderProcessingForm";
            this.Text = "OrderProcessingForm";
            this.Load += new System.EventHandler(this.OrderProcessingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_menuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_menuItems;
        private System.Windows.Forms.Button btn_addToOrder;
        private System.Windows.Forms.Button btn_PlaceOrder;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Timer orderStatusTimer;
        private System.Windows.Forms.ListBox listBox_selectedItems;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.Label label2;
    }
}