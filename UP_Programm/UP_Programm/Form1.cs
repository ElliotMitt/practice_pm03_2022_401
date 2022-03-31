using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_Programm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startDesign();
            panel3.Visible = true;
            panelProduct.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panelProduct.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
           
        }
        private void startDesign()
        {
            
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            
        }
    }
}
