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
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new AddVendor())
            {
                var result = addCustomerForm.ShowDialog(); 

                if (result == DialogResult.OK) 
                {
                    ShowData();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int vendorId = Convert.ToInt32(row.Cells["vid"].Value);

                EditVendor(vendorId);
            }
        }
        public void EditVendor(int vendorId)
        {
            using (var editVendorForm = new EditVendor(vendorId))
            {
                var result = editVendorForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ShowData();
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [inventorydb].dbo.[Vendor]", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in table.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        //dataGridView1.Rows[n].Cells["tid"].Value = item["ProductId"].ToString();

                        dataGridView1.Rows[n].Cells["vid"].Value = item["Id"].ToString();
                        dataGridView1.Rows[n].Cells["vname"].Value = item["VendorName"].ToString();
                        dataGridView1.Rows[n].Cells["vphone"].Value = item["VendorPhone"].ToString();

                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
