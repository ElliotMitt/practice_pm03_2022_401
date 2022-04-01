
namespace ComputerStore
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO_Cust = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO_Stuff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelStuff = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxStuff = new System.Windows.Forms.ComboBox();
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(565, 32);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 68;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(467, 395);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 67;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(370, 395);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 66;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(262, 395);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 65;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(4, 246);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 17);
            this.labelDate.TabIndex = 62;
            this.labelDate.Text = "Дата:";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(65, 197);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(90, 17);
            this.labelNum.TabIndex = 60;
            this.labelNum.Text = "Количество:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(156, 194);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber.TabIndex = 59;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(98, 153);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(52, 17);
            this.labelProduct.TabIndex = 58;
            this.labelProduct.Text = "Товар:";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(60, 118);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(90, 17);
            this.labelCustomer.TabIndex = 56;
            this.labelCustomer.Text = "Покупатель:";
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Location = new System.Drawing.Point(367, 46);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(57, 17);
            this.labelCustomers.TabIndex = 54;
            this.labelCustomers.Text = "Заказы";
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FIO_Cust,
            this.ProdName,
            this.ProdGroup,
            this.Price,
            this.Number,
            this.Date,
            this.Sum,
            this.FIO_Stuff});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(284, 102);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(537, 235);
            this.listViewOrders.TabIndex = 53;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewOrders_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // FIO_Cust
            // 
            this.FIO_Cust.Text = "ФИО покупателя";
            this.FIO_Cust.Width = 87;
            // 
            // ProdName
            // 
            this.ProdName.Text = "Товар";
            // 
            // ProdGroup
            // 
            this.ProdGroup.Text = "Группа товара";
            // 
            // Number
            // 
            this.Number.Text = "Количество";
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            // 
            // Sum
            // 
            this.Sum.Text = "Сумма";
            // 
            // FIO_Stuff
            // 
            this.FIO_Stuff.Text = "ФИО сотрудника";
            this.FIO_Stuff.Width = 94;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(56, 246);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDate.TabIndex = 69;
            // 
            // labelStuff
            // 
            this.labelStuff.AutoSize = true;
            this.labelStuff.Location = new System.Drawing.Point(68, 284);
            this.labelStuff.Name = "labelStuff";
            this.labelStuff.Size = new System.Drawing.Size(82, 17);
            this.labelStuff.TabIndex = 71;
            this.labelStuff.Text = "Сотрудник:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(156, 118);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCustomer.TabIndex = 72;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(156, 148);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProduct.TabIndex = 73;
            // 
            // comboBoxStuff
            // 
            this.comboBoxStuff.FormattingEnabled = true;
            this.comboBoxStuff.Location = new System.Drawing.Point(156, 284);
            this.comboBoxStuff.Name = "comboBoxStuff";
            this.comboBoxStuff.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStuff.TabIndex = 74;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.comboBoxStuff);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.labelStuff);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelCustomers);
            this.Controls.Add(this.listViewOrders);
            this.Name = "FormOrders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader FIO_Cust;
        private System.Windows.Forms.ColumnHeader ProdName;
        private System.Windows.Forms.ColumnHeader ProdGroup;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Sum;
        private System.Windows.Forms.ColumnHeader FIO_Stuff;
        private System.Windows.Forms.Label labelStuff;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxStuff;
        private System.Windows.Forms.ColumnHeader Price;
    }
}