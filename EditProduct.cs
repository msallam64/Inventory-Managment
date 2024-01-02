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

namespace Inventory
{
    public partial class EditProduct : Form
    {
        private int productId;
        public EditProduct(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            LoadProductInfo();
        }


        private void LoadProductInfo()
        {
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True";
            string query = "SELECT * FROM Product WHERE ProductId = @ProductId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming your form has textboxes named like this:
                            pcode.Text = reader["ProductCode"].ToString();
                            name.Text = reader["ProductName"].ToString();
                            quantity.Text = reader["StockQuantity"].ToString();
                            priceperweek.Text = reader["PricePerWeek"].ToString();
                            pricepermonth.Text = reader["PricePerMonth"].ToString();
                            isAsset.Checked = Convert.ToBoolean(reader["IsAsset"]);
                            type.Text = reader["ProductType"].ToString();
                        }
                    }
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True";
                string updateQuery = @"UPDATE Product SET 
                            ProductCode = @ProductCode, 
                            ProductName = @ProductName, 
                            StockQuantity = @StockQuantity, 
                            PricePerWeek = @PricePerWeek, 
                            PricePerMonth = @PricePerMonth, 
                            IsAsset = @IsAsset, 
                            ProductType = @ProductType 
                            WHERE ProductId = @productId";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId); // Add this line
                        cmd.Parameters.AddWithValue("@ProductCode", pcode.Text);
                        cmd.Parameters.AddWithValue("@ProductName", name.Text);
                        cmd.Parameters.AddWithValue("@StockQuantity", Convert.ToInt32(quantity.Text));
                        cmd.Parameters.AddWithValue("@PricePerWeek", Convert.ToDecimal(priceperweek.Text));
                        cmd.Parameters.AddWithValue("@PricePerMonth", Convert.ToDecimal(pricepermonth.Text));
                        cmd.Parameters.AddWithValue("@IsAsset", isAsset.Checked);
                        cmd.Parameters.AddWithValue("@ProductType", type.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Optional: Check if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully.");
                            this.DialogResult = DialogResult.OK; // This tells the Product form that the operation was successful
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update failed.");
                        }
                    }
                }


            } catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            

            
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
