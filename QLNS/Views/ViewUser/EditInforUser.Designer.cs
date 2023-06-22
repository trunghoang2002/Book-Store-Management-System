namespace QLNS.Views.ViewUser
{
    partial class EditInforUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInforUser));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbAddEditBook = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cTextBookIdBook = new QLNS.CustomTextBox();
            this.cTextBoxPhonenumber = new QLNS.CustomTextBox();
            this.cTextBoxEmail = new QLNS.CustomTextBox();
            this.cTextBoxAddress = new QLNS.CustomTextBox();
            this.cTextBoxIdStaff = new QLNS.CustomTextBox();
            this.cTextBoxStaffName = new QLNS.CustomTextBox();
            this.cBtnCancel = new QLNS.CustomButton();
            this.cBtnSave = new QLNS.CustomButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.lbAddEditBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 62);
            this.panel3.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1193, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(33, 17);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbAddEditBook
            // 
            this.lbAddEditBook.AutoSize = true;
            this.lbAddEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEditBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAddEditBook.Location = new System.Drawing.Point(69, 17);
            this.lbAddEditBook.Name = "lbAddEditBook";
            this.lbAddEditBook.Size = new System.Drawing.Size(100, 29);
            this.lbAddEditBook.TabIndex = 0;
            this.lbAddEditBook.Text = "Edit Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cTextBookIdBook);
            this.groupBox1.Controls.Add(this.cTextBoxPhonenumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cTextBoxEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labelLine);
            this.groupBox1.Controls.Add(this.cTextBoxAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupGender);
            this.groupBox1.Controls.Add(this.cTextBoxIdStaff);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cTextBoxStaffName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1223, 441);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(90, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 29);
            this.label11.TabIndex = 35;
            this.label11.Text = "Phone :  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(695, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Email :  ";
            // 
            // labelLine
            // 
            this.labelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelLine.Location = new System.Drawing.Point(21, 259);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(1160, 2);
            this.labelLine.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(71, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Address :  ";
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthDay.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerBirthDay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerBirthDay.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerBirthDay.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePickerBirthDay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(808, 172);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(384, 39);
            this.dateTimePickerBirthDay.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(627, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date of birth :  ";
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.rbFemale);
            this.groupGender.Controls.Add(this.radioButton2);
            this.groupGender.Controls.Add(this.rbMale);
            this.groupGender.Location = new System.Drawing.Point(95, 128);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(409, 107);
            this.groupGender.TabIndex = 9;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(209, 46);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(116, 33);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(214, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 33);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(75, 46);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(87, 33);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(74, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Staff \'s ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(625, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Staff\'s Name : ";
            // 
            // cTextBookIdBook
            // 
            this.cTextBookIdBook.BackColor = System.Drawing.Color.White;
            this.cTextBookIdBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cTextBookIdBook.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBookIdBook.BorderRadius = 4;
            this.cTextBookIdBook.BorderSize = 2;
            this.cTextBookIdBook.Enabled = false;
            this.cTextBookIdBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBookIdBook.ForeColor = System.Drawing.Color.Black;
            this.cTextBookIdBook.Location = new System.Drawing.Point(1235, -548);
            this.cTextBookIdBook.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBookIdBook.Multiline = false;
            this.cTextBookIdBook.Name = "cTextBookIdBook";
            this.cTextBookIdBook.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBookIdBook.PasswordChar = false;
            this.cTextBookIdBook.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBookIdBook.PlaceholderText = "ID Bill";
            this.cTextBookIdBook.Size = new System.Drawing.Size(300, 44);
            this.cTextBookIdBook.TabIndex = 37;
            this.cTextBookIdBook.Texts = "";
            this.cTextBookIdBook.UnderlinedStyle = false;
            // 
            // cTextBoxPhonenumber
            // 
            this.cTextBoxPhonenumber.BackColor = System.Drawing.Color.White;
            this.cTextBoxPhonenumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxPhonenumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxPhonenumber.BorderRadius = 4;
            this.cTextBoxPhonenumber.BorderSize = 2;
            this.cTextBoxPhonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxPhonenumber.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxPhonenumber.Location = new System.Drawing.Point(203, 281);
            this.cTextBoxPhonenumber.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxPhonenumber.Multiline = false;
            this.cTextBoxPhonenumber.Name = "cTextBoxPhonenumber";
            this.cTextBoxPhonenumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxPhonenumber.PasswordChar = false;
            this.cTextBoxPhonenumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxPhonenumber.PlaceholderText = "";
            this.cTextBoxPhonenumber.Size = new System.Drawing.Size(300, 47);
            this.cTextBoxPhonenumber.TabIndex = 36;
            this.cTextBoxPhonenumber.Texts = "";
            this.cTextBoxPhonenumber.UnderlinedStyle = false;
            // 
            // cTextBoxEmail
            // 
            this.cTextBoxEmail.BackColor = System.Drawing.Color.White;
            this.cTextBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxEmail.BorderRadius = 4;
            this.cTextBoxEmail.BorderSize = 2;
            this.cTextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxEmail.Location = new System.Drawing.Point(800, 281);
            this.cTextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxEmail.Multiline = false;
            this.cTextBoxEmail.Name = "cTextBoxEmail";
            this.cTextBoxEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxEmail.PasswordChar = false;
            this.cTextBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxEmail.PlaceholderText = "";
            this.cTextBoxEmail.Size = new System.Drawing.Size(384, 47);
            this.cTextBoxEmail.TabIndex = 34;
            this.cTextBoxEmail.Texts = "";
            this.cTextBoxEmail.UnderlinedStyle = false;
            // 
            // cTextBoxAddress
            // 
            this.cTextBoxAddress.BackColor = System.Drawing.Color.White;
            this.cTextBoxAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxAddress.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxAddress.BorderRadius = 4;
            this.cTextBoxAddress.BorderSize = 2;
            this.cTextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxAddress.Location = new System.Drawing.Point(204, 359);
            this.cTextBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxAddress.Multiline = false;
            this.cTextBoxAddress.Name = "cTextBoxAddress";
            this.cTextBoxAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxAddress.PasswordChar = false;
            this.cTextBoxAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxAddress.PlaceholderText = "";
            this.cTextBoxAddress.Size = new System.Drawing.Size(384, 47);
            this.cTextBoxAddress.TabIndex = 23;
            this.cTextBoxAddress.Texts = "";
            this.cTextBoxAddress.UnderlinedStyle = false;
            // 
            // cTextBoxIdStaff
            // 
            this.cTextBoxIdStaff.BackColor = System.Drawing.Color.White;
            this.cTextBoxIdStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxIdStaff.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxIdStaff.BorderRadius = 4;
            this.cTextBoxIdStaff.BorderSize = 2;
            this.cTextBoxIdStaff.Enabled = false;
            this.cTextBoxIdStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxIdStaff.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxIdStaff.Location = new System.Drawing.Point(204, 46);
            this.cTextBoxIdStaff.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxIdStaff.Multiline = false;
            this.cTextBoxIdStaff.Name = "cTextBoxIdStaff";
            this.cTextBoxIdStaff.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxIdStaff.PasswordChar = false;
            this.cTextBoxIdStaff.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxIdStaff.PlaceholderText = "";
            this.cTextBoxIdStaff.Size = new System.Drawing.Size(300, 47);
            this.cTextBoxIdStaff.TabIndex = 7;
            this.cTextBoxIdStaff.Texts = "";
            this.cTextBoxIdStaff.UnderlinedStyle = false;
            // 
            // cTextBoxStaffName
            // 
            this.cTextBoxStaffName.BackColor = System.Drawing.Color.White;
            this.cTextBoxStaffName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxStaffName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxStaffName.BorderRadius = 4;
            this.cTextBoxStaffName.BorderSize = 2;
            this.cTextBoxStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxStaffName.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxStaffName.Location = new System.Drawing.Point(808, 46);
            this.cTextBoxStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxStaffName.Multiline = false;
            this.cTextBoxStaffName.Name = "cTextBoxStaffName";
            this.cTextBoxStaffName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxStaffName.PasswordChar = false;
            this.cTextBoxStaffName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxStaffName.PlaceholderText = "";
            this.cTextBoxStaffName.Size = new System.Drawing.Size(384, 47);
            this.cTextBoxStaffName.TabIndex = 6;
            this.cTextBoxStaffName.Texts = "";
            this.cTextBoxStaffName.UnderlinedStyle = false;
            // 
            // cBtnCancel
            // 
            this.cBtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.cBtnCancel.BackgroundColor = System.Drawing.Color.IndianRed;
            this.cBtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cBtnCancel.BorderRadius = 5;
            this.cBtnCancel.BorderSize = 0;
            this.cBtnCancel.FlatAppearance.BorderSize = 0;
            this.cBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnCancel.ForeColor = System.Drawing.Color.White;
            this.cBtnCancel.Location = new System.Drawing.Point(642, 537);
            this.cBtnCancel.Name = "cBtnCancel";
            this.cBtnCancel.Size = new System.Drawing.Size(209, 51);
            this.cBtnCancel.TabIndex = 34;
            this.cBtnCancel.Text = "Cancel";
            this.cBtnCancel.TextColor = System.Drawing.Color.White;
            this.cBtnCancel.UseVisualStyleBackColor = false;
            this.cBtnCancel.Click += new System.EventHandler(this.cBtnCancel_Click);
            // 
            // cBtnSave
            // 
            this.cBtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cBtnSave.BorderRadius = 5;
            this.cBtnSave.BorderSize = 0;
            this.cBtnSave.FlatAppearance.BorderSize = 0;
            this.cBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnSave.ForeColor = System.Drawing.Color.White;
            this.cBtnSave.Location = new System.Drawing.Point(386, 537);
            this.cBtnSave.Name = "cBtnSave";
            this.cBtnSave.Size = new System.Drawing.Size(209, 51);
            this.cBtnSave.TabIndex = 33;
            this.cBtnSave.Text = "Save ";
            this.cBtnSave.TextColor = System.Drawing.Color.White;
            this.cBtnSave.UseVisualStyleBackColor = false;
            this.cBtnSave.Click += new System.EventHandler(this.cBtnSave_Click);
            // 
            // EditInforUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBtnCancel);
            this.Controls.Add(this.cBtnSave);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditInforUser";
            this.ShowInTaskbar = false;
            this.Text = "FormBill";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton cBtnCancel;
        private CustomButton cBtnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lbAddEditBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomTextBox cTextBookIdBook;
        private CustomTextBox cTextBoxPhonenumber;
        private System.Windows.Forms.Label label11;
        private CustomTextBox cTextBoxEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelLine;
        private CustomTextBox cTextBoxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private CustomTextBox cTextBoxIdStaff;
        private CustomTextBox cTextBoxStaffName;
    }
}