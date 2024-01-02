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
using static System.Collections.Specialized.BitVector32;

namespace Inventory
{
    public partial class AddOrder : Form
    {
        private DataTable dtCustomer;
        private DataTable dtVendor;
        private DataTable dtOrders;
        private int orderId;
        private int customerId = 0;
        private int vendorId = 0;
        private DateTime orderDate;
        // OrderProduct
        private int productId;
        private int orderQuantity;
        private decimal orderProductPrice;

        List<Product> products = new List<Product>();
        private int orderProductId;
        
        


        public AddOrder()
        {
            InitializeComponent();
            dtCustomer = getCustomer();
            dtVendor = getVendor();
            getProduct();
            displaySelectedProducts();
            
        }
        private void displaySelectedProducts()
        {
            dtOrders = new DataTable();
            dtOrders.Columns.Add("ProductCode", typeof(string));
            dtOrders.Columns.Add("Quantity", typeof(int));
            dtOrders.Columns.Add("ProductId", typeof(string));
            productdata.DataSource = dtOrders;
        }
        private void customer_CheckedChanged(object sender, EventArgs e)
        {
            if (customer.Checked)
            {
                cbox.DataSource = dtCustomer;
                cbox.DisplayMember = "CustomerName";
                cbox.ValueMember = "Id";
                cbox.SelectedIndex = -1; 
                vendorId = 0;

            }

        }

        private void vendor_CheckedChanged(object sender, EventArgs e)
        {
            if (vendor.Checked)
            {                
                cbox.DataSource = dtVendor;
                cbox.DisplayMember = "VendorName";
                cbox.ValueMember = "Id" ;
                cbox.SelectedIndex = -1;
                customerId = 0;

            }
            
        }

        

        private void getProduct()
        {
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True"; // Replace with your connection string
            string query = "SELECT ProductId,ProductCode,ProductName FROM Product";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    cListBox.DataSource = dt;
                    cListBox.DisplayMember = "ProductCode";
                    cListBox.ValueMember = "ProductId";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    

        private DataTable getVendor()
        {
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True"; // Replace with your connection string
            string query = "SELECT Id, VendorName FROM Vendor";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }

            return dt;

        }

        private DataTable getCustomer()
        {
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True"; // Replace with your connection string
            string query = "SELECT Id, CustomerName FROM Customer";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }

            return dt;

        }

        private void addsingleProduct_Click(object sender, EventArgs e)
        {
            if (singleProductQuantity.Value > 0)
            {
                for (int i = 0; i < cListBox.Items.Count; i++)
                {
                    if (cListBox.GetItemChecked(i))
                    {
                        DataRowView rowView = (DataRowView)cListBox.Items[i];
                        string selectedProductName = rowView["ProductCode"].ToString();
                        int quantity = (int)singleProductQuantity.Value;
                        String id = rowView["ProductId"].ToString();

                        dtOrders.Rows.Add(selectedProductName, quantity, id);


                        cListBox.SetItemChecked(i, false);
                        singleProductQuantity.Value = singleProductQuantity.Minimum;
                    }

                }
            }
            else
            {
                MessageBox.Show("Quantity Can Not Be 0 ! ");
            }

            
            
        }

          
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (orderDate == null)
            {
                orderDate = DateTime.Now.Date;
            }
            // Insert the order and retrieve the order ID

            orderId = InsertOrder(customerId, vendorId, orderDate);
            if (orderId <= 0)
            {
                // Handle the error: the order was not inserted correctly
                MessageBox.Show("Error: Order was not created.");
                return;
            }
            else
            {
            products = getProductsList();
            foreach (Product p in products)
            { 
                if(p != null)
                    {
                      InsertSingleOrderProduct(p.Id, orderId, p.Quantity);
                     }
                }
            }
            

        }

        private List<Product> getProductsList()
        {
            products = new List<Product>();
            foreach (DataGridViewRow row in productdata.Rows)
            {
                if (!row.IsNewRow)
                {
                    int id = Convert.ToInt32(row.Cells["ProductId"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    Product item = new Product()
                    {
                        Id = id,
                        Quantity = quantity
                    };

                    products.Add(item);
                }
            }
            return products;
        }

        private void InsertSingleOrderProduct
            (int productId, int orderId, int orderQuantity)
        {
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True";

            // SQL command to insert a new record
            string query = "INSERT INTO [dbo].[OrderProduct] (OrderId, ProductId, OrderQuantity) VALUES (@OrderId, @ProductId, @OrderQuantity)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.Parameters.AddWithValue("@ProductId", productId);
                    command.Parameters.AddWithValue("@OrderQuantity", orderQuantity);

                    // Open the connection
                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();

                    // Close the connection
                    connection.Close();
                }
                MessageBox.Show("Record Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private int InsertOrder(int customerId, int vendorId, DateTime orderDate)
        {
            

            int orderId = 0;
            string connectionString = @"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True";

            string query = "INSERT INTO [Order] (CustomerId, VendorId, OrderStartDate) VALUES (@CustomerId, @VendorId, @OrderStartDate); SELECT SCOPE_IDENTITY();";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId != 0 ? (object)customerId : DBNull.Value);
                    cmd.Parameters.AddWithValue("@VendorId", vendorId != 0 ? (object)vendorId : DBNull.Value);

                    cmd.Parameters.AddWithValue("@OrderStartDate", orderDate.Date); 
                    try
                    {
                        con.Open();
                        orderId = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred while inserting the order: " 
                            + ex.Message);
                    }
                }
            }

            return orderId;
        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(customer.Checked && cbox.SelectedValue != null) 
            {
                DataRowView selectedRow = (DataRowView)cbox.SelectedItem;
                customerId = Convert.ToInt32(selectedRow["Id"]);
                vendorId = 0;

            }
            else if (vendor.Checked)
            {
                if (cbox.SelectedValue != null && vendor.Checked)
                {
                    DataRowView selectedRow = (DataRowView)cbox.SelectedItem;
                    vendorId = Convert.ToInt32(selectedRow["Id"]);
                    customerId = 0;

                }
            }
            else
            {
                MessageBox.Show("Select Vendor Or Customer: ");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(orderstartdate.Value != null)
            {
                orderDate = orderstartdate.Value.Date;
            }
            else
            {
                orderDate = DateTime.Now.Date;
            }
        }
    }


    public class Product
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
    }

}
