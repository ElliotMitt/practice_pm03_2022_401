using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class FormMain : Form
    {
        private FormCustomers customer;
        private FormProducts products;
        private FormStuff stuff;
        private FormOrders orders;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStuff_Click(object sender, EventArgs e)
        {
            stuff = new FormStuff();
            stuff.Visible = true;
        }

        private void buttonCatalogs_Click(object sender, EventArgs e)
        {
            customer = new FormCustomers();
            customer.Visible = true;
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            products = new FormProducts();
            products.Visible = true;
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            orders = new FormOrders();
            orders.Visible = true;
        }
    }
}
