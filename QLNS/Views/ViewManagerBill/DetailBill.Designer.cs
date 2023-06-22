namespace QLNS.Views.ViewManagerBill
{
    partial class DetailBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cTextCustomerName = new QLNS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cTextIdBill = new QLNS.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCloseEditBill = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label_bill = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbLine1 = new System.Windows.Forms.Label();
            this.lbListOfBook = new System.Windows.Forms.Label();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel1 = new QLNS.CustomPanel();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cTextIdStaff = new QLNS.CustomTextBox();
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
            this.panel1.Size = new System.Drawing.Size(895, 119);
            this.panel1.TabIndex = 0;
            // 
            // cTextCustomerName
            // 
            this.cTextCustomerName.BackColor = System.Drawing.Color.White;
            this.cTextCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextCustomerName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextCustomerName.BorderRadius = 4;
            this.cTextCustomerName.BorderSize = 2;
            this.cTextCustomerName.Enabled = false;
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
            this.cTextCustomerName.Size = new System.Drawing.Size(360, 44);
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
            this.panel2.Size = new System.Drawing.Size(895, 138);
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
            this.label3.Location = new System.Drawing.Point(28, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date : ";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOrder.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerOrder.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerOrder.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerOrder.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePickerOrder.Enabled = false;
            this.dateTimePickerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrder.Location = new System.Drawing.Point(235, 87);
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
            this.panel3.Controls.Add(this.btnCloseEditBill);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label_bill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 62);
            this.panel3.TabIndex = 2;
            // 
            // btnCloseEditBill
            // 
            this.btnCloseEditBill.BackColor = System.Drawing.Color.White;
            this.btnCloseEditBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseEditBill.FlatAppearance.BorderSize = 0;
            this.btnCloseEditBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEditBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseEditBill.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseEditBill.Image")));
            this.btnCloseEditBill.Location = new System.Drawing.Point(853, 16);
            this.btnCloseEditBill.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseEditBill.Name = "btnCloseEditBill";
            this.btnCloseEditBill.Size = new System.Drawing.Size(30, 30);
            this.btnCloseEditBill.TabIndex = 3;
            this.btnCloseEditBill.UseVisualStyleBackColor = false;
            this.btnCloseEditBill.Click += new System.EventHandler(this.btnCloseEditBill_Click);
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
            // label_bill
            // 
            this.label_bill.AutoSize = true;
            this.label_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_bill.Location = new System.Drawing.Point(69, 17);
            this.label_bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_bill.Name = "label_bill";
            this.label_bill.Size = new System.Drawing.Size(115, 29);
            this.label_bill.TabIndex = 0;
            this.label_bill.Text = "Detail Bill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(28, 354);
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
            this.lbLine.Location = new System.Drawing.Point(33, 330);
            this.lbLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(700, 1);
            this.lbLine.TabIndex = 5;
            this.lbLine.Text = "line";
            // 
            // lbLine1
            // 
            this.lbLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine1.Location = new System.Drawing.Point(30, 411);
            this.lbLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLine1.Name = "lbLine1";
            this.lbLine1.Size = new System.Drawing.Size(700, 1);
            this.lbLine1.TabIndex = 6;
            this.lbLine1.Text = "line";
            // 
            // lbListOfBook
            // 
            this.lbListOfBook.AutoSize = true;
            this.lbListOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListOfBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbListOfBook.Location = new System.Drawing.Point(28, 461);
            this.lbListOfBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListOfBook.Name = "lbListOfBook";
            this.lbListOfBook.Size = new System.Drawing.Size(217, 25);
            this.lbListOfBook.TabIndex = 9;
            this.lbListOfBook.Text = "List Of Book Purchased";
            // 
            // dataGridViewBookOrder
            // 
            this.dataGridViewBookOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBookOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBookOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewBookOrder.ColumnHeadersHeight = 70;
            this.dataGridViewBookOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.Author,
            this.Category,
            this.Publisher,
            this.PublishingYear,
            this.Edition,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(30, 510);
            this.dataGridViewBookOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(853, 207);
            this.dataGridViewBookOrder.TabIndex = 10;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "Book\'s ID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 114;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book\'s name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 141;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 99;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 121;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.MinimumWidth = 6;
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 122;
            // 
            // PublishingYear
            // 
            this.PublishingYear.HeaderText = "Publishing year";
            this.PublishingYear.MinimumWidth = 6;
            this.PublishingYear.Name = "PublishingYear";
            this.PublishingYear.ReadOnly = true;
            this.PublishingYear.Width = 159;
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
            this.Quantity.Width = 114;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price(VND)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 141;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 6;
            this.customPanel1.Controls.Add(this.lbTotalAmount);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.customPanel1.Location = new System.Drawing.Point(248, 723);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(335, 62);
            this.customPanel1.TabIndex = 16;
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbTotalAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.Location = new System.Drawing.Point(181, 12);
            this.lbTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(138, 36);
            this.lbTotalAmount.TabIndex = 1;
            this.lbTotalAmount.Text = "0.0";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total ( VND ) : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cTextIdStaff.Location = new System.Drawing.Point(235, 347);
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
            // DetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 867);
            this.Controls.Add(this.customPanel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailBill";
            this.ShowInTaskbar = false;
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.DetailEditBill_Load);
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbLine1;
        private System.Windows.Forms.Label lbListOfBook;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private CustomTextBox cTextCustomerName;
        private CustomTextBox cTextIdBill;
        private CustomTextBox cTextIdStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalAmount;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Button btnCloseEditBill;
        private System.Windows.Forms.Label label_bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}