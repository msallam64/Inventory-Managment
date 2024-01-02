using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Inventory
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int checkboxValue = isAsset.Checked ? 1 : 0;
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True"))
                {
                    con.Open();

                    var sqlQuery = @"
                        INSERT INTO [inventorydb].dbo.[Product] 
                            (   [ProductCode], [ProductName], 
                                [StockQuantity], 
                                [PricePerWeek], [PricePerMonth], 
                                [IsAsset],[ProductType])
                        VALUES
                            (   @ProductCode, @ProductName, 
                                @StockQuantity, 
                                @PricePerWeek, @PricePerMonth, 
                                @IsAsset,@ProductType)";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@ProductCode", code.Text);
                        cmd.Parameters.AddWithValue("@ProductName", name.Text);
                        cmd.Parameters.AddWithValue("@StockQuantity", int.Parse(quantity.Text)); // Ensure this is a valid integer
                        cmd.Parameters.AddWithValue("@PricePerWeek", decimal.Parse(priceperweek.Text)); // Ensure this is a valid decimal
                        cmd.Parameters.AddWithValue("@PricePerMonth", decimal.Parse(pricepermonth.Text)); // Ensure this is a valid decimal
                        cmd.Parameters.AddWithValue("@IsAsset", checkboxValue);
                        cmd.Parameters.AddWithValue("@ProductType", type.Text);


                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // This tells the Product form that the operation was successful
                    this.Close();
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            // Uncomment if ShowData method is implemented
            // ShowData();
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricepermonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceperweek_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
