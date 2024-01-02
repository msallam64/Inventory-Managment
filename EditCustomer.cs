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
    public partial class EditCustomer : Form
    {
        private int customerId;
        public EditCustomer(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadCustomerInfo();
        }
        private void LoadCustomerInfo()
        {
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True";
            string query = "SELECT * FROM Customer WHERE Id = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", customerId);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming your form has textboxes named like this:
                            name.Text = reader["CustomerName"].ToString();
                            phone.Text = reader["CustomerPhone"].ToString();
                            
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
                string updateQuery = @"UPDATE Customer SET 
                            CustomerName = @CustomerName, 
                            CustomerPhone = @CustomerPhone 
                            WHERE Id = @Id
                            ";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", customerId); 
                        cmd.Parameters.AddWithValue("@CustomerName", name.Text);
                        cmd.Parameters.AddWithValue("@CustomerPhone", phone.Text);
                        

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Optional: Check if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.");
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

        private void EditCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
