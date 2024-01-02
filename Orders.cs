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
    public partial class Orders : Form
    {
        private int OrderId;
        public Orders()
        {
            InitializeComponent();
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var addOrderForm = new AddOrder())
            {
                var result = addOrderForm.ShowDialog(); // ShowDialog makes the form modal

                if (result == DialogResult.OK) // You can set DialogResult to OK when closing the form after inserting data
                {
                    ShowData(); 
                }
            }
        }

        private void ShowData()
        {
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True";

            string query = @"
                SELECT O.Id, O.OrderStartDate, O.OrderEndDate, O.TotalOrderPrice, 
               CASE 
                   WHEN O.CustomerId IS NOT NULL THEN (SELECT CustomerName FROM [dbo].[Customer] WHERE Id = O.CustomerId)
                   WHEN O.VendorId IS NOT NULL THEN (SELECT VendorName FROM [dbo].[Vendor] WHERE Id = O.VendorId)
                   ELSE 'N/A'
                        END AS EntityName
                FROM [dbo].[Order] O";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = 
                        new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }

                    // Assuming you have a DataGridView named ordersDataGridView
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Assuming OrderId is stored in a column, for example, the first column
                 OrderId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;


                using (var viewOrderForm = new ViewOrder(OrderId))
                {
                    var result = viewOrderForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        ShowData();
                    }
                }
            }
        }
    }
}
