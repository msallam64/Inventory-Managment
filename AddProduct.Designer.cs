namespace Inventory
{
    partial class AddProduct
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.pricepermonth = new System.Windows.Forms.TextBox();
            this.priceperweek = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.isAsset = new System.Windows.Forms.CheckBox();
            this.code = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(102, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(199, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Product Code";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(102, 222);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(199, 35);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Product Type";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(102, 401);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(361, 35);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Product Andalos Month Price";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(102, 345);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(361, 35);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Product Andalos Week Price";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(102, 281);
            this.textBox8.Margin = new System.Windows.Forms.Padding(5);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(305, 35);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Product Stock Quantity";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(102, 161);
            this.textBox9.Margin = new System.Windows.Forms.Padding(5);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(199, 35);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Product Name";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 100);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(540, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name.Location = new System.Drawing.Point(475, 161);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(369, 35);
            this.name.TabIndex = 11;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.SystemColors.HighlightText;
            this.type.Location = new System.Drawing.Point(475, 222);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(369, 35);
            this.type.TabIndex = 12;
            this.type.TextChanged += new System.EventHandler(this.type_TextChanged);
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.quantity.Location = new System.Drawing.Point(475, 281);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(369, 35);
            this.quantity.TabIndex = 13;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // pricepermonth
            // 
            this.pricepermonth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pricepermonth.Location = new System.Drawing.Point(475, 401);
            this.pricepermonth.Name = "pricepermonth";
            this.pricepermonth.Size = new System.Drawing.Size(369, 35);
            this.pricepermonth.TabIndex = 14;
            this.pricepermonth.TextChanged += new System.EventHandler(this.pricepermonth_TextChanged);
            // 
            // priceperweek
            // 
            this.priceperweek.BackColor = System.Drawing.SystemColors.HighlightText;
            this.priceperweek.Location = new System.Drawing.Point(475, 345);
            this.priceperweek.Name = "priceperweek";
            this.priceperweek.Size = new System.Drawing.Size(369, 35);
            this.priceperweek.TabIndex = 15;
            this.priceperweek.TextChanged += new System.EventHandler(this.priceperweek_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(413, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 71);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isAsset
            // 
            this.isAsset.AutoSize = true;
            this.isAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAsset.Location = new System.Drawing.Point(102, 457);
            this.isAsset.Name = "isAsset";
            this.isAsset.Size = new System.Drawing.Size(147, 36);
            this.isAsset.TabIndex = 18;
            this.isAsset.Text = "Is Asset";
            this.isAsset.UseVisualStyleBackColor = true;
            this.isAsset.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.SystemColors.HighlightText;
            this.code.Location = new System.Drawing.Point(475, 108);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(369, 35);
            this.code.TabIndex = 19;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 575);
            this.Controls.Add(this.code);
            this.Controls.Add(this.isAsset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceperweek);
            this.Controls.Add(this.pricepermonth);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.type);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox pricepermonth;
        private System.Windows.Forms.TextBox priceperweek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox isAsset;
        private System.Windows.Forms.TextBox code;
    }
}