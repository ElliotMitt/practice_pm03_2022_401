
namespace ComputerStore
{
    partial class FormCustomers
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelMidName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelFirName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLasName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.listViewCustomers = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(573, 32);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 36;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(475, 395);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 35;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(378, 395);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 34;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(270, 395);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(109, 277);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 31;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(164, 272);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 30;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(86, 239);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 17);
            this.labelPhone.TabIndex = 28;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(164, 234);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 27;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelMidName
            // 
            this.labelMidName.AutoSize = true;
            this.labelMidName.Location = new System.Drawing.Point(73, 197);
            this.labelMidName.Name = "labelMidName";
            this.labelMidName.Size = new System.Drawing.Size(75, 17);
            this.labelMidName.TabIndex = 26;
            this.labelMidName.Text = "Отчество:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(164, 194);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMiddleName.TabIndex = 25;
            // 
            // labelFirName
            // 
            this.labelFirName.AutoSize = true;
            this.labelFirName.Location = new System.Drawing.Point(112, 156);
            this.labelFirName.Name = "labelFirName";
            this.labelFirName.Size = new System.Drawing.Size(39, 17);
            this.labelFirName.TabIndex = 24;
            this.labelFirName.Text = "Имя:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(164, 153);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 23;
            // 
            // labelLasName
            // 
            this.labelLasName.AutoSize = true;
            this.labelLasName.Location = new System.Drawing.Point(81, 118);
            this.labelLasName.Name = "labelLasName";
            this.labelLasName.Size = new System.Drawing.Size(74, 17);
            this.labelLasName.TabIndex = 22;
            this.labelLasName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(164, 115);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 21;
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Location = new System.Drawing.Point(375, 46);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(87, 17);
            this.labelCustomers.TabIndex = 20;
            this.labelCustomers.Text = "Покупатели";
            // 
            // listViewCustomers
            // 
            this.listViewCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.Phone,
            this.Email});
            this.listViewCustomers.FullRowSelect = true;
            this.listViewCustomers.GridLines = true;
            this.listViewCustomers.HideSelection = false;
            this.listViewCustomers.Location = new System.Drawing.Point(284, 115);
            this.listViewCustomers.Name = "listViewCustomers";
            this.listViewCustomers.Size = new System.Drawing.Size(460, 235);
            this.listViewCustomers.TabIndex = 55;
            this.listViewCustomers.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers.View = System.Windows.Forms.View.Details;
            this.listViewCustomers.SelectedIndexChanged += new System.EventHandler(this.listViewCustomers_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // LastName
            // 
            this.LastName.Text = "Фамилия";
            this.LastName.Width = 90;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            // 
            // MiddleName
            // 
            this.MiddleName.Text = "Отчество";
            this.MiddleName.Width = 82;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 84;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 80;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCustomers);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelMidName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelFirName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLasName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelCustomers);
            this.Name = "FormCustomers";
            this.Text = "Покупатели";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelMidName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelFirName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLasName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.ListView listViewCustomers;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
    }
}