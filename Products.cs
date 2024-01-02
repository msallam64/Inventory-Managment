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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            ShowData();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var addProductForm = new AddProduct())
            {
                var result = addProductForm.ShowDialog(); // ShowDialog makes the form modal

                if (result == DialogResult.OK) // You can set DialogResult to OK when closing the form after inserting data
                {
                    ShowData(); // Refresh the DataGridView
                }
            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["pid"].Value);

                EditProduct(productId);
            }
        }
        public void EditProduct(int productId)
        {
            using (var editProductForm = new EditProduct(productId))
            {
                var result = editProductForm.ShowDialog();

                if (result == DialogResult.OK)
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [inventorydb].dbo.[Product]", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in table.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        //dataGridView1.Rows[n].Cells["tid"].Value = item["ProductId"].ToString();

                        dataGridView1.Rows[n].Cells["pcode"].Value = item["ProductCode"].ToString();
                        dataGridView1.Rows[n].Cells["pid"].Value = item["ProductId"].ToString();
                        dataGridView1.Rows[n].Cells["pname"].Value = item["ProductName"].ToString();
                        dataGridView1.Rows[n].Cells["quantity"].Value = item["StockQuantity"].ToString();
                        dataGridView1.Rows[n].Cells["perweek"].Value = item["PricePerWeek"].ToString();
                        dataGridView1.Rows[n].Cells["pmonth"].Value = item["PricePerMonth"].ToString();
                        dataGridView1.Rows[n].Cells["isAsset"].Value = item["IsAsset"].ToString();
                        dataGridView1.Rows[n].Cells["type"].Value = item["ProductType"].ToString();
            
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
