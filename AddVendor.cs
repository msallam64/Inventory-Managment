﻿using System;
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
    public partial class AddVendor : Form
    {
        public AddVendor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=ITMSALLAMR;Initial Catalog=inventorydb;Integrated Security=True"))
                {
                    con.Open();

                    var sqlQuery = @"
                        INSERT INTO [inventorydb].dbo.[Vendor] 
                            (   [VendorName], [VendorPhone])
                        VALUES
                            (   @VendorName, @VendorPhone)";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@VendorName", vname.Text);
                        cmd.Parameters.AddWithValue("@VendorPhone", vphone.Text);



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
        } 
    }
    
}
