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
    public partial class FormStuff : Form
    {
        void ShowStuff()
        {
            //Предварительно очищаем listView
            listViewStuff.Items.Clear();
            //Проходимся по коллекции сотрудников, которые находятся в базе с помощью foreach
            foreach (Stuff stuff in Program.csDb.Stuff)
            {

                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
            {
                    //указываем необходимые поля
                    stuff.Id.ToString(),
                    stuff.LastName,
                    stuff.FirstName,
                    stuff.MiddleName,
                    stuff.Phone,
                    stuff.Purpose

            });
                //указываем по какому тегу будем брать элементы
                item.Tag = stuff;
                //добавляем элементы в listView для отображения
                listViewStuff.Items.Add(item);
            }
            listViewStuff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormStuff()
        {
            InitializeComponent();
            ShowStuff();
        }

        private void FormStuff_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса сотрудники
                Stuff stuff = new Stuff();
                //Делаем ссылку на объект, который хранится в textBox-ax
                stuff.FirstName = textBoxFirstName.Text;
                stuff.MiddleName = textBoxMiddleName.Text;
                stuff.LastName = textBoxLastName.Text;
                stuff.Phone = textBoxPhone.Text;
                stuff.Purpose = textBoxPurpose.Text;
                if (stuff.FirstName == "" || stuff.MiddleName == "" || stuff.LastName == "")
                {
                    throw new Exception("Не заполнены поля ФИО");
                }
                //Добавляем в таблицу Stuff нового сотрудника stuff
                Program.csDb.Stuff.Add(stuff);
                //Сохраняем изменения в модели csDb (экземпляр которой был создан ранее)
                Program.csDb.SaveChanges();
                ShowStuff();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStuff.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    Stuff stuff = listViewStuff.SelectedItems[0].Tag as Stuff;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    stuff.FirstName = textBoxFirstName.Text;
                    stuff.MiddleName = textBoxMiddleName.Text;
                    stuff.LastName = textBoxLastName.Text;
                    stuff.Phone = textBoxPhone.Text;
                    stuff.Purpose = textBoxPurpose.Text;
                    if (stuff.FirstName == "" || stuff.MiddleName == "" || stuff.LastName == "")
                    {
                        throw new Exception("Не заполнены поля ФИО");
                    }
                    //Сохраняем изменения в модели csDb (экземпляр которой был создан ранее)
                    Program.csDb.SaveChanges();
                    ShowStuff();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewStuff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStuff.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Stuff stuff = listViewStuff.SelectedItems[0].Tag as Stuff;
                //указываем, что может быть изменено
                textBoxFirstName.Text = stuff.FirstName;
                textBoxMiddleName.Text = stuff.MiddleName;
                textBoxLastName.Text = stuff.LastName;
                textBoxPhone.Text = stuff.Phone;
                textBoxPurpose.Text = stuff.Purpose;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPurpose.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewStuff.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    Stuff stuff = listViewStuff.SelectedItems[0].Tag as Stuff;
                    //удаляем из модели и базы данных
                    Program.csDb.Stuff.Remove(stuff);
                    //сохраняем изменения
                    Program.csDb.SaveChanges();
                    //отображаем обновленный список
                    ShowStuff();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPurpose.Text = "";
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
