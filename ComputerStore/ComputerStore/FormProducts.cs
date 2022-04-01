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
    public partial class FormProducts : Form
    {
        void ShowProducts()
        {
            //Предварительно очищаем listView
            listViewProducts.Items.Clear();
            //Проходимся по коллекции товаров, которые находятся в базе с помощью foreach
            foreach (Products products in Program.csDb.Products)
            {

                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
            {
                    //указываем необходимые поля
                    products.Id.ToString(),
                    products.Title,
                    products.Price.ToString(),
                    products.Number.ToString(),
                    products.Mark.ToString(),
                    products.Pr_group,
                    products.Description

            });
                //указываем по какому тегу будем брать элементы
                item.Tag = products;
                //добавляем элементы в listView для отображения
                listViewProducts.Items.Add(item);
            }
            listViewProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormProducts()
        {
            InitializeComponent();
            ShowProducts();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса товары
                Products products = new Products();
                //Делаем ссылку на объект, который хранится в textBox-ax
                products.Title = textBoxTitle.Text;
                products.Price = Convert.ToInt32(textBoxPrice.Text);
                products.Number = Convert.ToInt32(textBoxNum.Text);
                products.Mark = Convert.ToInt32(textBoxMark.Text);
                products.Pr_group = comboBoxGroup.SelectedItem.ToString().Split('.')[0];
                products.Description = textBoxDesc.Text;
                //Добавляем в таблицу Products новый товар products
                Program.csDb.Products.Add(products);
                //Сохраняем изменения в модели csDb (экземпляр которой был создан ранее)
                Program.csDb.SaveChanges();
                ShowProducts();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProducts.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    Products products = listViewProducts.SelectedItems[0].Tag as Products;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    products.Title = textBoxTitle.Text;
                    products.Price = Convert.ToInt32(textBoxPrice.Text);
                    products.Number = Convert.ToInt32(textBoxNum.Text);
                    products.Mark = Convert.ToInt32(textBoxMark.Text);
                    products.Pr_group = comboBoxGroup.SelectedItem.ToString().Split('.')[0];
                    products.Description = textBoxDesc.Text;
                    //Сохраняем изменения в модели csDb (экземпляр которой был создан ранее)
                    Program.csDb.SaveChanges();
                    ShowProducts();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Products products = listViewProducts.SelectedItems[0].Tag as Products;
                //указываем, что может быть изменено
                textBoxTitle.Text = products.Title;
                textBoxPrice.Text = products.Price.ToString();
                textBoxNum.Text = products.Number.ToString();
                textBoxMark.Text = products.Mark.ToString();
                comboBoxGroup.SelectedIndex = comboBoxGroup.FindString(products.Pr_group);
                textBoxDesc.Text = products.Description;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxTitle.Text = "";
                textBoxPrice.Text = "";
                textBoxNum.Text = "";
                textBoxMark.Text = "";
                comboBoxGroup.SelectedItem = null;
                textBoxDesc.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 1)
            {
                //ищем этот элемент
                Products products = listViewProducts.SelectedItems[0].Tag as Products;
                //удаляем из модели и базы данных
                Program.csDb.Products.Remove(products);
                //сохраняем изменения
                Program.csDb.SaveChanges();
                //отображаем обновленный список
                ShowProducts();
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxTitle.Text = "";
                textBoxPrice.Text = "";
                textBoxNum.Text = "";
                textBoxMark.Text = "";
                comboBoxGroup.SelectedItem = null;
                textBoxDesc.Text = "";
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничиваем ввод данных
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничиваем ввод данных
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }

        private void textBoxMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничиваем ввод данных
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 54) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
