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
    public partial class ViewOrder : Form
    {
        private int OrderId;

        public ViewOrder(int OrderId)
        {
            InitializeComponent();
            this.OrderId = OrderId;
            if (OrderId > 0 && OrderId != null)
            {
               // ViewOrderDetails(OrderId);

            }
            else
            {
                MessageBox.Show("Error: Order was not Found.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void ViewOrderDetails(int orderId)
        {
            string connectionString = "YourConnectionStringHere";

           
            string query = "SELECT * FROM Order WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the orderId as a parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@OrderId", orderId);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and obtain a SqlDataReader to read the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Process each record
                                // Example: Console.WriteLine(reader["ColumnName"].ToString());

                                // Replace 'ColumnName' with the actual names of your columns
                                // and process the data as needed (e.g., storing in a list, displaying in UI, etc.)
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions (e.g., log the error)
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
