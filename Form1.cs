using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products newForm = new Products(); // Create an instance of Form2
            newForm.ShowDialog(); // Show Form2
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers newForm = new Customers(); // Create an instance of Form2
            newForm.ShowDialog(); // Show Form2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendor newForm = new Vendor(); // Create an instance of Form2
            newForm.ShowDialog(); // Show Form2
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders newForm = new Orders(); // Create an instance of Form2
            newForm.ShowDialog(); // Show Form2
        }
    }
}
