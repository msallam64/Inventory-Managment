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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int customerId = Convert.ToInt32(row.Cells["cid"].Value);

                EditCustomer(customerId);
            }
        }
        public void EditCustomer(int customerId)
        {
            using (var editProductForm = new EditCustomer(customerId))
            {
                var result = editProductForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ShowData(); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new AddCustomer())
            {
                var result = addCustomerForm.ShowDialog(); // ShowDialog makes the form modal

                if (result == DialogResult.OK) // You can set DialogResult to OK when closing the form after inserting data
                {
                    ShowData(); // Refresh the DataGridView
                }
            }
        }



        public void ShowData()
        {
            ;

            // Use using statements for better resource management
            using (
                SqlConnection con =
                new SqlConnection(@"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True"))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [inventorydb].dbo.[Customer]", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in table.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        //dataGridView1.Rows[n].Cells["tid"].Value = item["ProductId"].ToString();

                        dataGridView1.Rows[n].Cells["cid"].Value = item["Id"].ToString();
                        dataGridView1.Rows[n].Cells["cname"].Value = item["CustomerName"].ToString();
                        dataGridView1.Rows[n].Cells["cphone"].Value = item["CustomerPhone"].ToString();
                        
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
