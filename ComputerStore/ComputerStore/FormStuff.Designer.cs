
namespace ComputerStore
{
    partial class FormStuff
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
            this.labelPurpose = new System.Windows.Forms.Label();
            this.textBoxPurpose = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelMidName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelFirName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLasName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.listViewStuff = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Purpose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(561, 32);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 52;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(463, 395);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 51;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(366, 395);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 50;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(258, 395);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 49;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.Location = new System.Drawing.Point(53, 277);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(93, 17);
            this.labelPurpose.TabIndex = 48;
            this.labelPurpose.Text = "Назначение:";
            // 
            // textBoxPurpose
            // 
            this.textBoxPurpose.Location = new System.Drawing.Point(152, 272);
            this.textBoxPurpose.Name = "textBoxPurpose";
            this.textBoxPurpose.Size = new System.Drawing.Size(100, 22);
            this.textBoxPurpose.TabIndex = 47;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(74, 239);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 17);
            this.labelPhone.TabIndex = 46;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(152, 234);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 45;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelMidName
            // 
            this.labelMidName.AutoSize = true;
            this.labelMidName.Location = new System.Drawing.Point(61, 197);
            this.labelMidName.Name = "labelMidName";
            this.labelMidName.Size = new System.Drawing.Size(75, 17);
            this.labelMidName.TabIndex = 44;
            this.labelMidName.Text = "Отчество:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(152, 194);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMiddleName.TabIndex = 43;
            // 
            // labelFirName
            // 
            this.labelFirName.AutoSize = true;
            this.labelFirName.Location = new System.Drawing.Point(100, 156);
            this.labelFirName.Name = "labelFirName";
            this.labelFirName.Size = new System.Drawing.Size(39, 17);
            this.labelFirName.TabIndex = 42;
            this.labelFirName.Text = "Имя:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(152, 153);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 41;
            // 
            // labelLasName
            // 
            this.labelLasName.AutoSize = true;
            this.labelLasName.Location = new System.Drawing.Point(69, 118);
            this.labelLasName.Name = "labelLasName";
            this.labelLasName.Size = new System.Drawing.Size(74, 17);
            this.labelLasName.TabIndex = 40;
            this.labelLasName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(152, 115);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 39;
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Location = new System.Drawing.Point(363, 46);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(86, 17);
            this.labelCustomers.TabIndex = 38;
            this.labelCustomers.Text = "Сотрудники";
            // 
            // listViewStuff
            // 
            this.listViewStuff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.Phone,
            this.Purpose});
            this.listViewStuff.FullRowSelect = true;
            this.listViewStuff.GridLines = true;
            this.listViewStuff.HideSelection = false;
            this.listViewStuff.Location = new System.Drawing.Point(272, 115);
            this.listViewStuff.Name = "listViewStuff";
            this.listViewStuff.Size = new System.Drawing.Size(460, 235);
            this.listViewStuff.TabIndex = 54;
            this.listViewStuff.UseCompatibleStateImageBehavior = false;
            this.listViewStuff.View = System.Windows.Forms.View.Details;
            this.listViewStuff.SelectedIndexChanged += new System.EventHandler(this.listViewStuff_SelectedIndexChanged);
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
            // Purpose
            // 
            this.Purpose.Text = "Назначение";
            this.Purpose.Width = 80;
            // 
            // FormStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewStuff);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPurpose);
            this.Controls.Add(this.textBoxPurpose);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelMidName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelFirName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLasName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelCustomers);
            this.Name = "FormStuff";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.FormStuff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.TextBox textBoxPurpose;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelMidName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelFirName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLasName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.ListView listViewStuff;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Purpose;
    }
}