namespace QLNS.Views.ViewBook
{
    partial class AddEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditBook));
            this.numericSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericCostPrice = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cTextBoxAuthorName = new QLNS.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cTextBoxIdBook = new QLNS.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cTextBoxBookName = new QLNS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericEdition = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBtnCancel = new QLNS.CustomButton();
            this.cBtnSave = new QLNS.CustomButton();
            this.lbLine1 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbAddEditBook = new System.Windows.Forms.Label();
            this.numericYearPublish = new System.Windows.Forms.NumericUpDown();
            this.cbPublish = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCostPrice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdition)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearPublish)).BeginInit();
            this.SuspendLayout();
            // 
            // numericSellingPrice
            // 
            this.numericSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSellingPrice.Location = new System.Drawing.Point(717, 498);
            this.numericSellingPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericSellingPrice.Name = "numericSellingPrice";
            this.numericSellingPrice.Size = new System.Drawing.Size(190, 38);
            this.numericSellingPrice.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(545, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Selling price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(28, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cost price : ";
            // 
            // numericCostPrice
            // 
            this.numericCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCostPrice.Location = new System.Drawing.Point(235, 498);
            this.numericCostPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericCostPrice.Name = "numericCostPrice";
            this.numericCostPrice.Size = new System.Drawing.Size(190, 38);
            this.numericCostPrice.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cTextBoxAuthorName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 135);
            this.panel2.TabIndex = 28;
            // 
            // cTextBoxAuthorName
            // 
            this.cTextBoxAuthorName.BackColor = System.Drawing.Color.White;
            this.cTextBoxAuthorName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxAuthorName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxAuthorName.BorderRadius = 4;
            this.cTextBoxAuthorName.BorderSize = 2;
            this.cTextBoxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxAuthorName.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxAuthorName.Location = new System.Drawing.Point(235, 20);
            this.cTextBoxAuthorName.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxAuthorName.Multiline = false;
            this.cTextBoxAuthorName.Name = "cTextBoxAuthorName";
            this.cTextBoxAuthorName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxAuthorName.PasswordChar = false;
            this.cTextBoxAuthorName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxAuthorName.PlaceholderText = "";
            this.cTextBoxAuthorName.Size = new System.Drawing.Size(476, 47);
            this.cTextBoxAuthorName.TabIndex = 5;
            this.cTextBoxAuthorName.Texts = "";
            this.cTextBoxAuthorName.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category : ";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(235, 79);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(300, 39);
            this.cbCategory.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.cTextBoxIdBook);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cTextBoxBookName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 119);
            this.panel1.TabIndex = 27;
            // 
            // cTextBoxIdBook
            // 
            this.cTextBoxIdBook.BackColor = System.Drawing.Color.White;
            this.cTextBoxIdBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxIdBook.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxIdBook.BorderRadius = 4;
            this.cTextBoxIdBook.BorderSize = 2;
            this.cTextBoxIdBook.Enabled = false;
            this.cTextBoxIdBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxIdBook.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxIdBook.Location = new System.Drawing.Point(235, 7);
            this.cTextBoxIdBook.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxIdBook.Multiline = false;
            this.cTextBoxIdBook.Name = "cTextBoxIdBook";
            this.cTextBoxIdBook.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxIdBook.PasswordChar = false;
            this.cTextBoxIdBook.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxIdBook.PlaceholderText = "";
            this.cTextBoxIdBook.Size = new System.Drawing.Size(300, 47);
            this.cTextBoxIdBook.TabIndex = 4;
            this.cTextBoxIdBook.Texts = "";
            this.cTextBoxIdBook.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(28, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Book\'s ID : ";
            // 
            // cTextBoxBookName
            // 
            this.cTextBoxBookName.BackColor = System.Drawing.Color.White;
            this.cTextBoxBookName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxBookName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxBookName.BorderRadius = 4;
            this.cTextBoxBookName.BorderSize = 2;
            this.cTextBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxBookName.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBookName.Location = new System.Drawing.Point(235, 65);
            this.cTextBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxBookName.Multiline = false;
            this.cTextBoxBookName.Name = "cTextBoxBookName";
            this.cTextBoxBookName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxBookName.PasswordChar = false;
            this.cTextBoxBookName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxBookName.PlaceholderText = "";
            this.cTextBoxBookName.Size = new System.Drawing.Size(476, 47);
            this.cTextBoxBookName.TabIndex = 1;
            this.cTextBoxBookName.Texts = "";
            this.cTextBoxBookName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book\'s name : ";
            // 
            // numericEdition
            // 
            this.numericEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEdition.Location = new System.Drawing.Point(717, 411);
            this.numericEdition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEdition.Name = "numericEdition";
            this.numericEdition.Size = new System.Drawing.Size(190, 38);
            this.numericEdition.TabIndex = 39;
            this.numericEdition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(605, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Edition : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(28, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Name Publishser : ";
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
            this.cBtnCancel.Location = new System.Drawing.Point(521, 610);
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
            this.cBtnSave.Location = new System.Drawing.Point(284, 610);
            this.cBtnSave.Name = "cBtnSave";
            this.cBtnSave.Size = new System.Drawing.Size(209, 51);
            this.cBtnSave.TabIndex = 33;
            this.cBtnSave.Text = "Save ";
            this.cBtnSave.TextColor = System.Drawing.Color.White;
            this.cBtnSave.UseVisualStyleBackColor = false;
            this.cBtnSave.Click += new System.EventHandler(this.cBtnSave_Click);
            // 
            // lbLine1
            // 
            this.lbLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine1.Location = new System.Drawing.Point(30, 474);
            this.lbLine1.Name = "lbLine1";
            this.lbLine1.Size = new System.Drawing.Size(700, 2);
            this.lbLine1.TabIndex = 32;
            this.lbLine1.Text = "line";
            // 
            // lbLine
            // 
            this.lbLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine.Location = new System.Drawing.Point(30, 333);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(700, 2);
            this.lbLine.TabIndex = 31;
            this.lbLine.Text = "line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(28, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Year Publish : ";
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
            this.panel3.Size = new System.Drawing.Size(1034, 62);
            this.panel3.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(993, 14);
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
            this.lbAddEditBook.Size = new System.Drawing.Size(118, 29);
            this.lbAddEditBook.TabIndex = 0;
            this.lbAddEditBook.Text = "Add Book";
            // 
            // numericYearPublish
            // 
            this.numericYearPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericYearPublish.Location = new System.Drawing.Point(235, 408);
            this.numericYearPublish.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericYearPublish.Name = "numericYearPublish";
            this.numericYearPublish.Size = new System.Drawing.Size(190, 38);
            this.numericYearPublish.TabIndex = 40;
            // 
            // cbPublish
            // 
            this.cbPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPublish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbPublish.FormattingEnabled = true;
            this.cbPublish.Location = new System.Drawing.Point(235, 347);
            this.cbPublish.Name = "cbPublish";
            this.cbPublish.Size = new System.Drawing.Size(300, 39);
            this.cbPublish.TabIndex = 36;
            // 
            // AddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 705);
            this.Controls.Add(this.numericSellingPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPublish);
            this.Controls.Add(this.numericYearPublish);
            this.Controls.Add(this.numericCostPrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericEdition);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBtnCancel);
            this.Controls.Add(this.cBtnSave);
            this.Controls.Add(this.lbLine1);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddEditBook";
            this.ShowInTaskbar = false;
            this.Text = "FormBill";
            ((System.ComponentModel.ISupportInitialize)(this.numericSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCostPrice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdition)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearPublish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericSellingPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericCostPrice;
        private System.Windows.Forms.Panel panel2;
        private CustomTextBox cTextBoxAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox cTextBoxIdBook;
        private System.Windows.Forms.Label label8;
        private CustomTextBox cTextBoxBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericEdition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private CustomButton cBtnCancel;
        private CustomButton cBtnSave;
        private System.Windows.Forms.Label lbLine1;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lbAddEditBook;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown numericYearPublish;
        private System.Windows.Forms.ComboBox cbPublish;
    }
}