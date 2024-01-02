namespace Inventory
{
    partial class ViewOrder
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
            this.customer = new System.Windows.Forms.RadioButton();
            this.vendor = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderstartdate = new System.Windows.Forms.DateTimePicker();
            this.singleProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.addsingleProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productdata = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.singleProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(343, 74);
            this.customer.Margin = new System.Windows.Forms.Padding(5);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(150, 33);
            this.customer.TabIndex = 30;
            this.customer.TabStop = true;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            // 
            // vendor
            // 
            this.vendor.AutoSize = true;
            this.vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendor.Location = new System.Drawing.Point(573, 74);
            this.vendor.Margin = new System.Windows.Forms.Padding(5);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(122, 33);
            this.vendor.TabIndex = 31;
            this.vendor.TabStop = true;
            this.vendor.Text = "Vendor";
            this.vendor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Order For";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Select Customer/Vendor";
            // 
            // cbox
            // 
            this.cbox.FormattingEnabled = true;
            this.cbox.Location = new System.Drawing.Point(343, 123);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(447, 28);
            this.cbox.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Select Products";
            // 
            // orderstartdate
            // 
            this.orderstartdate.Location = new System.Drawing.Point(343, 175);
            this.orderstartdate.Name = "orderstartdate";
            this.orderstartdate.Size = new System.Drawing.Size(447, 26);
            this.orderstartdate.TabIndex = 41;
            // 
            // singleProductQuantity
            // 
            this.singleProductQuantity.Location = new System.Drawing.Point(343, 416);
            this.singleProductQuantity.Name = "singleProductQuantity";
            this.singleProductQuantity.Size = new System.Drawing.Size(120, 26);
            this.singleProductQuantity.TabIndex = 37;
            // 
            // addsingleProduct
            // 
            this.addsingleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsingleProduct.Location = new System.Drawing.Point(497, 416);
            this.addsingleProduct.Name = "addsingleProduct";
            this.addsingleProduct.Size = new System.Drawing.Size(198, 49);
            this.addsingleProduct.TabIndex = 38;
            this.addsingleProduct.Text = "Add Product";
            this.addsingleProduct.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(159, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 71);
            this.button1.TabIndex = 39;
            this.button1.Text = "Delete Order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // productdata
            // 
            this.productdata.AllowUserToAddRows = false;
            this.productdata.AllowUserToDeleteRows = false;
            this.productdata.BackgroundColor = System.Drawing.Color.LightGray;
            this.productdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdata.Location = new System.Drawing.Point(343, 229);
            this.productdata.Name = "productdata";
            this.productdata.ReadOnly = true;
            this.productdata.RowHeadersWidth = 62;
            this.productdata.RowTemplate.Height = 28;
            this.productdata.Size = new System.Drawing.Size(433, 164);
            this.productdata.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.orderId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 56);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Order Date";
            // 
            // orderId
            // 
            this.orderId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderId.AutoSize = true;
            this.orderId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.ForeColor = System.Drawing.Color.White;
            this.orderId.Location = new System.Drawing.Point(635, 9);
            this.orderId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(44, 37);
            this.orderId.TabIndex = 1;
            this.orderId.Text = "id";
            this.orderId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(67, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "Order Info";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(487, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 71);
            this.button2.TabIndex = 43;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderstartdate);
            this.Controls.Add(this.productdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addsingleProduct);
            this.Controls.Add(this.singleProductQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.customer);
            this.Name = "ViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrder";
            ((System.ComponentModel.ISupportInitialize)(this.singleProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton customer;
        private System.Windows.Forms.RadioButton vendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker orderstartdate;
        private System.Windows.Forms.NumericUpDown singleProductQuantity;
        private System.Windows.Forms.Button addsingleProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView productdata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label orderId;
        private System.Windows.Forms.Button button2;
    }
}