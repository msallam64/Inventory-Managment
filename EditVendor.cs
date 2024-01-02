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
using System.Xml.Linq;

namespace Inventory
{
    public partial class EditVendor : Form
    {
        private int vendorID;
        public EditVendor(int vendorID)
        {
            InitializeComponent();
            this.vendorID = vendorID;
            LoadVendorInfo(vendorID);
        }
        private void LoadVendorInfo(int vendorID)
        {
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True";
            string query = "SELECT * FROM Vendor WHERE Id = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", vendorID);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming your form has textboxes named like this:
                            vname.Text = reader["VendorName"].ToString();
                            vphone.Text = reader["VendorPhone"].ToString();

                        }
                    }
                }


            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditVendor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True";
                string updateQuery = @"UPDATE Vendor SET 
                            VendorName = @VendorName, 
                            VendorPhone = @VendorPhone 
                            WHERE Id = @Id
                            ";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", vendorID);
                        cmd.Parameters.AddWithValue("@VendorName", vname.Text);
                        cmd.Parameters.AddWithValue("@VendorPhone", vphone.Text);


                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Optional: Check if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vendor updated successfully.");
                            this.DialogResult = DialogResult.OK; // This tells the Product form that the operation was successful
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update failed.");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
