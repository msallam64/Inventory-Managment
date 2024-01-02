namespace Inventory
{
    partial class AddOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.RadioButton();
            this.vendor = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cListBox = new System.Windows.Forms.CheckedListBox();
            this.singleProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.addsingleProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productdata = new System.Windows.Forms.DataGridView();
            this.orderstartdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 56);
            this.panel1.TabIndex = 10;
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
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(341, 80);
            this.customer.Margin = new System.Windows.Forms.Padding(5);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(150, 33);
            this.customer.TabIndex = 11;
            this.customer.TabStop = true;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.CheckedChanged += new System.EventHandler(this.customer_CheckedChanged);
            // 
            // vendor
            // 
            this.vendor.AutoSize = true;
            this.vendor.Location = new System.Drawing.Point(571, 80);
            this.vendor.Margin = new System.Windows.Forms.Padding(5);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(122, 33);
            this.vendor.TabIndex = 12;
            this.vendor.TabStop = true;
            this.vendor.Text = "Vendor";
            this.vendor.UseVisualStyleBackColor = true;
            this.vendor.CheckedChanged += new System.EventHandler(this.vendor_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Order For";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Customer/Vendor";
            // 
            // cbox
            // 
            this.cbox.FormattingEnabled = true;
            this.cbox.Location = new System.Drawing.Point(341, 129);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(447, 37);
            this.cbox.TabIndex = 15;
            this.cbox.SelectedIndexChanged += new System.EventHandler(this.cbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select Products";
            // 
            // cListBox
            // 
            this.cListBox.FormattingEnabled = true;
            this.cListBox.Location = new System.Drawing.Point(341, 232);
            this.cListBox.Name = "cListBox";
            this.cListBox.Size = new System.Drawing.Size(377, 164);
            this.cListBox.TabIndex = 17;
            // 
            // singleProductQuantity
            // 
            this.singleProductQuantity.Location = new System.Drawing.Point(341, 422);
            this.singleProductQuantity.Name = "singleProductQuantity";
            this.singleProductQuantity.Size = new System.Drawing.Size(120, 35);
            this.singleProductQuantity.TabIndex = 18;
            // 
            // addsingleProduct
            // 
            this.addsingleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsingleProduct.Location = new System.Drawing.Point(495, 422);
            this.addsingleProduct.Name = "addsingleProduct";
            this.addsingleProduct.Size = new System.Drawing.Size(198, 49);
            this.addsingleProduct.TabIndex = 20;
            this.addsingleProduct.Text = "Add Product";
            this.addsingleProduct.UseVisualStyleBackColor = true;
            this.addsingleProduct.Click += new System.EventHandler(this.addsingleProduct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(350, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 71);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productdata
            // 
            this.productdata.AllowUserToAddRows = false;
            this.productdata.AllowUserToDeleteRows = false;
            this.productdata.BackgroundColor = System.Drawing.Color.LightGray;
            this.productdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdata.Location = new System.Drawing.Point(744, 232);
            this.productdata.Name = "productdata";
            this.productdata.ReadOnly = true;
            this.productdata.RowHeadersWidth = 62;
            this.productdata.RowTemplate.Height = 28;
            this.productdata.Size = new System.Drawing.Size(433, 164);
            this.productdata.TabIndex = 26;
            // 
            // orderstartdate
            // 
            this.orderstartdate.Location = new System.Drawing.Point(341, 181);
            this.orderstartdate.Name = "orderstartdate";
            this.orderstartdate.Size = new System.Drawing.Size(447, 35);
            this.orderstartdate.TabIndex = 27;
            this.orderstartdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Order Date";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 728);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderstartdate);
            this.Controls.Add(this.productdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addsingleProduct);
            this.Controls.Add(this.singleProductQuantity);
            this.Controls.Add(this.cListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton customer;
        private System.Windows.Forms.RadioButton vendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cListBox;
        private System.Windows.Forms.NumericUpDown singleProductQuantity;
        private System.Windows.Forms.Button addsingleProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView productdata;
        private System.Windows.Forms.DateTimePicker orderstartdate;
        private System.Windows.Forms.Label label5;
    }
}