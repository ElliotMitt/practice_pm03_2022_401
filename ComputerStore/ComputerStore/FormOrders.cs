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
    public partial class FormOrders : Form
    {
        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (Orders orders in Program.csDb.Orders)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    orders.Id.ToString(),
                    orders.Customers.LastName +" "+orders.Customers.FirstName.Remove(1) +". "+ orders.Customers.MiddleName.Remove(1)+" .",
                    orders.Products.Title,
                    orders.Products.Pr_group,
                    orders.Products.Price.ToString(),
                    orders.Num.ToString(),
                    orders.Date.ToString(),
                    orders.SumPrice.ToString(),
                    orders.Stuff.LastName +" "+orders.Stuff.FirstName.Remove(1) +". "+ orders.Stuff.MiddleName.Remove(1)+" ."
                });
                item.Tag = orders;
                listViewOrders.Items.Add(item);
            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowCustomers()
        {
            comboBoxCustomer.Items.Clear();
            foreach (Customers customer in Program.csDb.Customers)
            {
                string[] item = { customer.Id.ToString() + ". ", customer.LastName + " " + customer.FirstName.Remove(1) + ". " + customer.MiddleName.Remove(1) + " ." };
                comboBoxCustomer.Items.Add(string.Join(" ", item));
            }
        }

        void ShowProducts()
        {
            comboBoxProduct.Items.Clear();
            foreach (Products product in Program.csDb.Products)
            {
                string[] item = { product.Id.ToString() + ". ", product.Title + ". Группа: " + product.Pr_group + ". Цена: " + product.Price};
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStuff()
        {
            comboBoxStuff.Items.Clear();
            foreach (Stuff stuff in Program.csDb.Stuff)
            {
                string[] item = { stuff.Id.ToString() + ". ", stuff.LastName + " " + stuff.FirstName.Remove(1) + ". " + stuff.MiddleName.Remove(1) + " ." };
                comboBoxStuff.Items.Add(string.Join(" ", item));
            }
        }
        public FormOrders()
        {
            InitializeComponent();
            ShowOrders();
            ShowCustomers();
            ShowProducts();
            ShowStuff();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCustomer.SelectedItem != null && comboBoxProduct.SelectedItem != null
                    && comboBoxStuff.SelectedItem != null && dateTimePickerDate.Value != null && textBoxNumber.Text != "")
                {
                    Orders orders = new Orders();
                    orders.Id_Product = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                    orders.Id_Customer = Convert.ToInt32(comboBoxCustomer.SelectedItem.ToString().Split('.')[0]);
                    orders.Id_Stuff = Convert.ToInt32(comboBoxStuff.SelectedItem.ToString().Split('.')[0]);
                    orders.Date = dateTimePickerDate.Value;
                    orders.Num = Convert.ToInt32(textBoxNumber.Text);
                    orders.SumPrice = 72000;
                    Program.csDb.Orders.Add(orders);
                    Program.csDb.SaveChanges();
                    ShowOrders();
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    if (comboBoxCustomer.SelectedItem != null && comboBoxProduct.SelectedItem != null
                    && comboBoxStuff.SelectedItem != null && dateTimePickerDate.Value != null && textBoxNumber.Text != "")
                    {
                        Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                        orders.Id_Product = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                        orders.Id_Customer = Convert.ToInt32(comboBoxCustomer.SelectedItem.ToString().Split('.')[0]);
                        orders.Id_Stuff = Convert.ToInt32(comboBoxStuff.SelectedItem.ToString().Split('.')[0]);
                        orders.Date = dateTimePickerDate.Value;
                        orders.Num = Convert.ToInt32(textBoxNumber.Text);
                        orders.SumPrice = orders.Num * orders.Products.Price;
                        Program.csDb.SaveChanges();
                        ShowOrders();
                    }
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                comboBoxProduct.SelectedIndex = comboBoxProduct.FindString(orders.Id_Product.ToString());
                comboBoxCustomer.SelectedIndex = comboBoxCustomer.FindString(orders.Id_Customer.ToString());
                comboBoxStuff.SelectedIndex = comboBoxStuff.FindString(orders.Id_Stuff.ToString());
                dateTimePickerDate.Value = Convert.ToDateTime(orders.Date);
                textBoxNumber.Text = orders.Num.ToString();
            }
            else
            {
                comboBoxProduct.SelectedItem = null;
                comboBoxCustomer.SelectedItem = null;
                comboBoxStuff.SelectedItem = null;
                dateTimePickerDate.Value = DateTime.Now;
                textBoxNumber.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                    Program.csDb.Orders.Remove(orders);
                    Program.csDb.SaveChanges();
                    ShowOrders();
                }
                comboBoxProduct.SelectedItem = null;
                comboBoxCustomer.SelectedItem = null;
                comboBoxStuff.SelectedItem = null;
                dateTimePickerDate.Value = DateTime.Now;
                textBoxNumber.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничиваем ввод данных
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
