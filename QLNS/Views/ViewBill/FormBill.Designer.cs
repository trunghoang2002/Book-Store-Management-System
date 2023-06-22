namespace QLNS.Views.ViewBill
{
    partial class FormBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cTextCustomerName = new QLNS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cTextIdBill = new QLNS.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbLine1 = new System.Windows.Forms.Label();
            this.lbListOfBook = new System.Windows.Forms.Label();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel1 = new QLNS.CustomPanel();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBtnCancel = new QLNS.CustomButton();
            this.cBtnSaveAndPrint = new QLNS.CustomButton();
            this.cBtnRemoveBook = new QLNS.CustomButton();
            this.cBtnAddBook = new QLNS.CustomButton();
            this.cTextIdStaff = new QLNS.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.cTextCustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 119);
            this.panel1.TabIndex = 0;
            // 
            // cTextCustomerName
            // 
            this.cTextCustomerName.BackColor = System.Drawing.Color.White;
            this.cTextCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextCustomerName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextCustomerName.BorderRadius = 4;
            this.cTextCustomerName.BorderSize = 2;
            this.cTextCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextCustomerName.ForeColor = System.Drawing.Color.Black;
            this.cTextCustomerName.Location = new System.Drawing.Point(235, 46);
            this.cTextCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.cTextCustomerName.Multiline = false;
            this.cTextCustomerName.Name = "cTextCustomerName";
            this.cTextCustomerName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextCustomerName.PasswordChar = false;
            this.cTextCustomerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextCustomerName.PlaceholderText = "";
            this.cTextCustomerName.Size = new System.Drawing.Size(476, 44);
            this.cTextCustomerName.TabIndex = 1;
            this.cTextCustomerName.Texts = "";
            this.cTextCustomerName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cTextIdBill);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePickerOrder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 138);
            this.panel2.TabIndex = 1;
            // 
            // cTextIdBill
            // 
            this.cTextIdBill.BackColor = System.Drawing.Color.White;
            this.cTextIdBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextIdBill.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextIdBill.BorderRadius = 4;
            this.cTextIdBill.BorderSize = 2;
            this.cTextIdBill.Enabled = false;
            this.cTextIdBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextIdBill.ForeColor = System.Drawing.Color.Black;
            this.cTextIdBill.Location = new System.Drawing.Point(235, 14);
            this.cTextIdBill.Margin = new System.Windows.Forms.Padding(4);
            this.cTextIdBill.Multiline = false;
            this.cTextIdBill.Name = "cTextIdBill";
            this.cTextIdBill.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextIdBill.PasswordChar = false;
            this.cTextIdBill.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextIdBill.PlaceholderText = "ID Bill";
            this.cTextIdBill.Size = new System.Drawing.Size(360, 44);
            this.cTextIdBill.TabIndex = 2;
            this.cTextIdBill.Texts = "";
            this.cTextIdBill.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date : ";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOrder.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerOrder.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerOrder.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerOrder.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePickerOrder.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOrder.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOrder.Location = new System.Drawing.Point(235, 82);
            this.dateTimePickerOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(360, 39);
            this.dateTimePickerOrder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Bill : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 62);
            this.panel3.TabIndex = 2;
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
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(69, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create Bill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(28, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Staff  : ";
            // 
            // lbLine
            // 
            this.lbLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine.Location = new System.Drawing.Point(30, 322);
            this.lbLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(700, 2);
            this.lbLine.TabIndex = 5;
            this.lbLine.Text = "line";
            // 
            // lbLine1
            // 
            this.lbLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine1.Location = new System.Drawing.Point(30, 447);
            this.lbLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLine1.Name = "lbLine1";
            this.lbLine1.Size = new System.Drawing.Size(700, 2);
            this.lbLine1.TabIndex = 6;
            this.lbLine1.Text = "line";
            // 
            // lbListOfBook
            // 
            this.lbListOfBook.AutoSize = true;
            this.lbListOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListOfBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbListOfBook.Location = new System.Drawing.Point(28, 474);
            this.lbListOfBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListOfBook.Name = "lbListOfBook";
            this.lbListOfBook.Size = new System.Drawing.Size(186, 25);
            this.lbListOfBook.TabIndex = 9;
            this.lbListOfBook.Text = "List Of Book To Buy";
            // 
            // dataGridViewBookOrder
            // 
            this.dataGridViewBookOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBookOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookOrder.ColumnHeadersHeight = 70;
            this.dataGridViewBookOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Book,
            this.TitleBook,
            this.Author,
            this.Category,
            this.Publisher,
            this.PublishingYear,
            this.Edition,
            this.Quantity,
            this.OriginalPrice,
            this.Discount,
            this.RealPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(30, 515);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(1011, 207);
            this.dataGridViewBookOrder.TabIndex = 10;
            // 
            // ID_Book
            // 
            this.ID_Book.HeaderText = "Book\'s ID";
            this.ID_Book.MinimumWidth = 6;
            this.ID_Book.Name = "ID_Book";
            this.ID_Book.ReadOnly = true;
            // 
            // TitleBook
            // 
            this.TitleBook.HeaderText = "Book\'s name";
            this.TitleBook.MinimumWidth = 6;
            this.TitleBook.Name = "TitleBook";
            this.TitleBook.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.MinimumWidth = 6;
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // PublishingYear
            // 
            this.PublishingYear.HeaderText = "Publishing year";
            this.PublishingYear.MinimumWidth = 6;
            this.PublishingYear.Name = "PublishingYear";
            this.PublishingYear.ReadOnly = true;
            // 
            // Edition
            // 
            this.Edition.HeaderText = "Edition";
            this.Edition.MinimumWidth = 6;
            this.Edition.Name = "Edition";
            this.Edition.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.HeaderText = "Original price(VND)";
            this.OriginalPrice.MinimumWidth = 6;
            this.OriginalPrice.Name = "OriginalPrice";
            this.OriginalPrice.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount(%)";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // RealPrice
            // 
            this.RealPrice.HeaderText = "Real price(VND)";
            this.RealPrice.MinimumWidth = 6;
            this.RealPrice.Name = "RealPrice";
            this.RealPrice.ReadOnly = true;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 6;
            this.customPanel1.Controls.Add(this.lbTotalCost);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.customPanel1.Location = new System.Drawing.Point(706, 728);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(335, 62);
            this.customPanel1.TabIndex = 16;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.Location = new System.Drawing.Point(181, 12);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(138, 36);
            this.lbTotalCost.TabIndex = 1;
            this.lbTotalCost.Text = "0.0";
            this.lbTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total ( VND ) : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBtnCancel
            // 
            this.cBtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cBtnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cBtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cBtnCancel.BorderRadius = 5;
            this.cBtnCancel.BorderSize = 0;
            this.cBtnCancel.FlatAppearance.BorderSize = 0;
            this.cBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnCancel.Location = new System.Drawing.Point(271, 779);
            this.cBtnCancel.Name = "cBtnCancel";
            this.cBtnCancel.Size = new System.Drawing.Size(209, 51);
            this.cBtnCancel.TabIndex = 14;
            this.cBtnCancel.Text = "Cancel";
            this.cBtnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnCancel.UseVisualStyleBackColor = false;
            this.cBtnCancel.Click += new System.EventHandler(this.cBtnCancel_Click);
            // 
            // cBtnSaveAndPrint
            // 
            this.cBtnSaveAndPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnSaveAndPrint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnSaveAndPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cBtnSaveAndPrint.BorderRadius = 5;
            this.cBtnSaveAndPrint.BorderSize = 0;
            this.cBtnSaveAndPrint.FlatAppearance.BorderSize = 0;
            this.cBtnSaveAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnSaveAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnSaveAndPrint.ForeColor = System.Drawing.Color.White;
            this.cBtnSaveAndPrint.Location = new System.Drawing.Point(33, 779);
            this.cBtnSaveAndPrint.Name = "cBtnSaveAndPrint";
            this.cBtnSaveAndPrint.Size = new System.Drawing.Size(209, 51);
            this.cBtnSaveAndPrint.TabIndex = 13;
            this.cBtnSaveAndPrint.Text = "Save and Print";
            this.cBtnSaveAndPrint.TextColor = System.Drawing.Color.White;
            this.cBtnSaveAndPrint.UseVisualStyleBackColor = false;
            this.cBtnSaveAndPrint.Click += new System.EventHandler(this.cBtnSaveAndPrint_Click);
            // 
            // cBtnRemoveBook
            // 
            this.cBtnRemoveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cBtnRemoveBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cBtnRemoveBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnRemoveBook.BorderRadius = 5;
            this.cBtnRemoveBook.BorderSize = 0;
            this.cBtnRemoveBook.FlatAppearance.BorderSize = 0;
            this.cBtnRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnRemoveBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnRemoveBook.Image = ((System.Drawing.Image)(resources.GetObject("cBtnRemoveBook.Image")));
            this.cBtnRemoveBook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cBtnRemoveBook.Location = new System.Drawing.Point(485, 466);
            this.cBtnRemoveBook.Name = "cBtnRemoveBook";
            this.cBtnRemoveBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cBtnRemoveBook.Size = new System.Drawing.Size(191, 40);
            this.cBtnRemoveBook.TabIndex = 12;
            this.cBtnRemoveBook.Text = "Remove Book";
            this.cBtnRemoveBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnRemoveBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnRemoveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBtnRemoveBook.UseVisualStyleBackColor = false;
            this.cBtnRemoveBook.Click += new System.EventHandler(this.cBtnRemoveBook_Click);
            // 
            // cBtnAddBook
            // 
            this.cBtnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cBtnAddBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cBtnAddBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnAddBook.BorderRadius = 5;
            this.cBtnAddBook.BorderSize = 0;
            this.cBtnAddBook.FlatAppearance.BorderSize = 0;
            this.cBtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("cBtnAddBook.Image")));
            this.cBtnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnAddBook.Location = new System.Drawing.Point(271, 466);
            this.cBtnAddBook.Name = "cBtnAddBook";
            this.cBtnAddBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cBtnAddBook.Size = new System.Drawing.Size(191, 40);
            this.cBtnAddBook.TabIndex = 11;
            this.cBtnAddBook.Text = "Add Book";
            this.cBtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnAddBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBtnAddBook.UseVisualStyleBackColor = false;
            this.cBtnAddBook.Click += new System.EventHandler(this.cBtnAddBook_Click);
            // 
            // cTextIdStaff
            // 
            this.cTextIdStaff.BackColor = System.Drawing.Color.White;
            this.cTextIdStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextIdStaff.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextIdStaff.BorderRadius = 4;
            this.cTextIdStaff.BorderSize = 2;
            this.cTextIdStaff.Enabled = false;
            this.cTextIdStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextIdStaff.ForeColor = System.Drawing.Color.Black;
            this.cTextIdStaff.Location = new System.Drawing.Point(235, 337);
            this.cTextIdStaff.Margin = new System.Windows.Forms.Padding(4);
            this.cTextIdStaff.Multiline = false;
            this.cTextIdStaff.Name = "cTextIdStaff";
            this.cTextIdStaff.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextIdStaff.PasswordChar = false;
            this.cTextIdStaff.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextIdStaff.PlaceholderText = "ID Staff";
            this.cTextIdStaff.Size = new System.Drawing.Size(360, 44);
            this.cTextIdStaff.TabIndex = 4;
            this.cTextIdStaff.Texts = "";
            this.cTextIdStaff.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(28, 397);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Payment : ";
            // 
            // cbPayment
            // 
            this.cbPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(235, 397);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(245, 37);
            this.cbPayment.TabIndex = 18;
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 921);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.cBtnCancel);
            this.Controls.Add(this.cBtnSaveAndPrint);
            this.Controls.Add(this.cBtnRemoveBook);
            this.Controls.Add(this.cBtnAddBook);
            this.Controls.Add(this.cTextIdStaff);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.lbListOfBook);
            this.Controls.Add(this.lbLine1);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbLine1;
        private System.Windows.Forms.Label lbListOfBook;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private CustomTextBox cTextCustomerName;
        private CustomTextBox cTextIdBill;
        private CustomTextBox cTextIdStaff;
        private CustomButton cBtnAddBook;
        private CustomButton cBtnRemoveBook;
        private CustomButton cBtnSaveAndPrint;
        private CustomButton cBtnCancel;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealPrice;
    }
}