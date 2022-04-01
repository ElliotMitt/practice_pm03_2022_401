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
    public partial class FormCustomers : Form
    {
        void ShowCustomers()
        {
            //Предварительно очищаем listView
            listViewCustomers.Items.Clear();
            //Проходимся по коллекции товаров, которые находятся в базе с помощью foreach
            foreach (Customers customers in Program.csDb.Customers)
            {

                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
            {
                    //указываем необходимые поля
                    customers.Id.ToString(),
                    customers.LastName,
                    customers.FirstName,
                    customers.MiddleName,
                    customers.Phone,
                    customers.Email

            });
                //указываем по какому тегу будем брать элементы
                item.Tag = customers;
                //добавляем элементы в listView для отображения
                listViewCustomers.Items.Add(item);
            }
            listViewCustomers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormCustomers()
        {
            InitializeComponent();
            ShowCustomers();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса покупатели
                Customers customers = new Customers();
                //Делаем ссылку на объект, который хранится в textBox-ax
                customers.FirstName = textBoxFirstName.Text;
                customers.MiddleName = textBoxMiddleName.Text;
                customers.LastName = textBoxLastName.Text;
                customers.Phone = textBoxPhone.Text;
                customers.Email = textBoxEmail.Text;
                if (customers.FirstName == "" || customers.MiddleName == "" || customers.LastName == "")
                {
                    throw new Exception("Не заполнены поля ФИО");
                }
                //Добавляем в таблицу Customers нового сотрудника customers
                Program.csDb.Customers.Add(customers);
                //Сохраняем изменения в модели csDb (экземпляр которой был создан ранее)
                Program.csDb.SaveChanges();
                ShowCustomers();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCustomers.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    Customers customers = listViewCustomers.SelectedItems[0].Tag as Customers;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    customers.FirstName = textBoxFirstName.Text;
                    customers.MiddleName = textBoxMiddleName.Text;
                    customers.LastName = textBoxLastName.Text;
                    customers.Phone = textBoxPhone.Text;
                    customers.Email = textBoxEmail.Text;
                    if (customers.FirstName == "" || customers.MiddleName == "" || customers.LastName == "")
                    {
                        throw new Exception("Не заполнены поля ФИО");
                    }
                    //Сохраняем изменения в модели csDb (экземпляр которой был создан ранее)
                    Program.csDb.SaveChanges();
                    ShowCustomers();
                }
            } catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void listViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustomers.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Customers customers = listViewCustomers.SelectedItems[0].Tag as Customers;
                //указываем, что может быть изменено
                textBoxFirstName.Text = customers.FirstName;
                textBoxMiddleName.Text = customers.MiddleName;
                textBoxLastName.Text = customers.LastName;
                textBoxPhone.Text = customers.Phone;
                textBoxEmail.Text = customers.Email;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewCustomers.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    Customers customers = listViewCustomers.SelectedItems[0].Tag as Customers;
                    //удаляем из модели и базы данных
                    Program.csDb.Customers.Remove(customers);
                    //сохраняем изменения
                    Program.csDb.SaveChanges();
                    //отображаем обновленный список
                    ShowCustomers();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
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
