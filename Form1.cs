using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_Abramowicz_Matthew_Unit3_IT481
{
    public partial class Form1 : Form
    {
        DB database;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            database = new DB("Server = MATTKID\\SQLEXPRESS; " +
                    "Trusted_Connection=true;" +
                    "Database=northwind;" +
                    "User Instance=false;" +
                    "Connection timeout=30");
            MessageBox.Show("Connection information sent");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer count");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCustomerNames();
            MessageBox.Show(names, "CustomerNames");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string count = database.getOrderCount();
            MessageBox.Show(count, "Order count");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string orderid = database.getOrder();
            MessageBox.Show(orderid, "OrderID");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeeCount();
            MessageBox.Show(count, "Employee count");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string names = database.getEmployeeLastName();
            MessageBox.Show(names, "EmployeeLastName");
        }
    }
}