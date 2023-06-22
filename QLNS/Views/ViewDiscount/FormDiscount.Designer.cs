namespace QLNS.Views.ViewDiscount
{
    partial class FormDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscount));
            this.panelheader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.iBtnSort = new FontAwesome.Sharp.IconButton();
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewLisfOfDiscount = new System.Windows.Forms.DataGridView();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTextBoxBoxSearch = new QLNS.CustomTextBox();
            this.cBtnAdd = new QLNS.CustomButton();
            this.cBtnClear = new QLNS.CustomButton();
            this.cBtnSave = new QLNS.CustomButton();
            this.cTextBoxDiscount = new QLNS.CustomTextBox();
            this.cTextBoxPriceAfterDiscount = new QLNS.CustomTextBox();
            this.cTextBoxSellingPrice = new QLNS.CustomTextBox();
            this.cTextBoxIdBook = new QLNS.CustomTextBox();
            this.cTextBoxBookName = new QLNS.CustomTextBox();
            this.panelheader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLisfOfDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelheader.Location = new System.Drawing.Point(274, 22);
            this.panelheader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1096, 49);
            this.panelheader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1090, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Management Discount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1641, 12);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewLisfOfDiscount);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1617, 517);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of discount";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.cTextBoxBoxSearch);
            this.panel1.Controls.Add(this.iBtnSearch);
            this.panel1.Controls.Add(this.cbSort);
            this.panel1.Controls.Add(this.iBtnSort);
            this.panel1.Controls.Add(this.iBtnEdit);
            this.panel1.Controls.Add(this.iBtnDelete);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(6, 423);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1605, 89);
            this.panel1.TabIndex = 23;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.IconSize = 30;
            this.iBtnSearch.Location = new System.Drawing.Point(1523, 20);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(65, 47);
            this.iBtnSearch.TabIndex = 28;
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // cbSort
            // 
            this.cbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSort.BackColor = System.Drawing.Color.White;
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(579, 22);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(245, 39);
            this.cbSort.TabIndex = 21;
            // 
            // iBtnSort
            // 
            this.iBtnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnSort.FlatAppearance.BorderSize = 0;
            this.iBtnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnSort.IconChar = FontAwesome.Sharp.IconChar.SortAmountDownAlt;
            this.iBtnSort.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnSort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSort.IconSize = 30;
            this.iBtnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnSort.Location = new System.Drawing.Point(465, 1);
            this.iBtnSort.Name = "iBtnSort";
            this.iBtnSort.Size = new System.Drawing.Size(100, 83);
            this.iBtnSort.TabIndex = 20;
            this.iBtnSort.Text = "Sort";
            this.iBtnSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnSort.UseVisualStyleBackColor = true;
            this.iBtnSort.Click += new System.EventHandler(this.iBtnSort_Click);
            // 
            // iBtnEdit
            // 
            this.iBtnEdit.FlatAppearance.BorderSize = 0;
            this.iBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iBtnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEdit.IconSize = 30;
            this.iBtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnEdit.Location = new System.Drawing.Point(45, 1);
            this.iBtnEdit.Name = "iBtnEdit";
            this.iBtnEdit.Size = new System.Drawing.Size(144, 83);
            this.iBtnEdit.TabIndex = 19;
            this.iBtnEdit.Text = "Edit";
            this.iBtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEdit.UseVisualStyleBackColor = true;
            this.iBtnEdit.Click += new System.EventHandler(this.iBtnEdit_Click);
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.FlatAppearance.BorderSize = 0;
            this.iBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iBtnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.IconSize = 30;
            this.iBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelete.Location = new System.Drawing.Point(195, 1);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(144, 83);
            this.iBtnDelete.TabIndex = 18;
            this.iBtnDelete.Text = "Delete";
            this.iBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cBtnAdd);
            this.groupBox1.Controls.Add(this.cBtnClear);
            this.groupBox1.Controls.Add(this.cBtnSave);
            this.groupBox1.Controls.Add(this.cTextBoxDiscount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cTextBoxPriceAfterDiscount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cTextBoxSellingPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelLine);
            this.groupBox1.Controls.Add(this.cTextBoxIdBook);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cTextBoxBookName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1617, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Discount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(698, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Discount (%) : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(20, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Price after discount : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(20, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Selling Price : ";
            // 
            // labelLine
            // 
            this.labelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelLine.Location = new System.Drawing.Point(25, 117);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(1201, 2);
            this.labelLine.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(46, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Book\'s ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(734, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book\'s name: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewLisfOfDiscount
            // 
            this.dataGridViewLisfOfDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLisfOfDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLisfOfDiscount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLisfOfDiscount.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLisfOfDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLisfOfDiscount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLisfOfDiscount.ColumnHeadersHeight = 70;
            this.dataGridViewLisfOfDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Book,
            this.TitleBook,
            this.Author,
            this.Category,
            this.Publisher,
            this.PublishingYear,
            this.Edition,
            this.CostPrice,
            this.SellingPrice,
            this.Discount,
            this.RealPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLisfOfDiscount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLisfOfDiscount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewLisfOfDiscount.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewLisfOfDiscount.Name = "dataGridViewLisfOfDiscount";
            this.dataGridViewLisfOfDiscount.ReadOnly = true;
            this.dataGridViewLisfOfDiscount.RowHeadersVisible = false;
            this.dataGridViewLisfOfDiscount.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewLisfOfDiscount.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLisfOfDiscount.RowTemplate.Height = 24;
            this.dataGridViewLisfOfDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLisfOfDiscount.Size = new System.Drawing.Size(1605, 389);
            this.dataGridViewLisfOfDiscount.TabIndex = 28;
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
            // CostPrice
            // 
            this.CostPrice.HeaderText = "Cost price(VND)";
            this.CostPrice.MinimumWidth = 6;
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.HeaderText = "Selling price(VND)";
            this.SellingPrice.MinimumWidth = 6;
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
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
            // cTextBoxBoxSearch
            // 
            this.cTextBoxBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBoxBoxSearch.BackColor = System.Drawing.Color.White;
            this.cTextBoxBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxBoxSearch.BorderRadius = 4;
            this.cTextBoxBoxSearch.BorderSize = 2;
            this.cTextBoxBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBoxSearch.Location = new System.Drawing.Point(1216, 20);
            this.cTextBoxBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxBoxSearch.Multiline = false;
            this.cTextBoxBoxSearch.Name = "cTextBoxBoxSearch";
            this.cTextBoxBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxBoxSearch.PasswordChar = false;
            this.cTextBoxBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxBoxSearch.PlaceholderText = "";
            this.cTextBoxBoxSearch.Size = new System.Drawing.Size(300, 47);
            this.cTextBoxBoxSearch.TabIndex = 29;
            this.cTextBoxBoxSearch.Texts = "";
            this.cTextBoxBoxSearch.UnderlinedStyle = false;
            // 
            // cBtnAdd
            // 
            this.cBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cBtnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cBtnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnAdd.BorderRadius = 4;
            this.cBtnAdd.BorderSize = 0;
            this.cBtnAdd.FlatAppearance.BorderSize = 0;
            this.cBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("cBtnAdd.Image")));
            this.cBtnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cBtnAdd.Location = new System.Drawing.Point(518, 51);
            this.cBtnAdd.Name = "cBtnAdd";
            this.cBtnAdd.Size = new System.Drawing.Size(137, 43);
            this.cBtnAdd.TabIndex = 40;
            this.cBtnAdd.Text = "Add new";
            this.cBtnAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBtnAdd.UseVisualStyleBackColor = false;
            this.cBtnAdd.Click += new System.EventHandler(this.cBtnAdd_Click);
            // 
            // cBtnClear
            // 
            this.cBtnClear.BackColor = System.Drawing.Color.IndianRed;
            this.cBtnClear.BackgroundColor = System.Drawing.Color.IndianRed;
            this.cBtnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cBtnClear.BorderRadius = 5;
            this.cBtnClear.BorderSize = 0;
            this.cBtnClear.FlatAppearance.BorderSize = 0;
            this.cBtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnClear.ForeColor = System.Drawing.Color.White;
            this.cBtnClear.Location = new System.Drawing.Point(1282, 146);
            this.cBtnClear.Name = "cBtnClear";
            this.cBtnClear.Size = new System.Drawing.Size(240, 75);
            this.cBtnClear.TabIndex = 39;
            this.cBtnClear.Text = "Clear";
            this.cBtnClear.TextColor = System.Drawing.Color.White;
            this.cBtnClear.UseVisualStyleBackColor = false;
            this.cBtnClear.Click += new System.EventHandler(this.cBtnClear_Click);
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
            this.cBtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnSave.ForeColor = System.Drawing.Color.White;
            this.cBtnSave.Location = new System.Drawing.Point(1282, 35);
            this.cBtnSave.Name = "cBtnSave";
            this.cBtnSave.Size = new System.Drawing.Size(240, 75);
            this.cBtnSave.TabIndex = 38;
            this.cBtnSave.Text = "Save ";
            this.cBtnSave.TextColor = System.Drawing.Color.White;
            this.cBtnSave.UseVisualStyleBackColor = false;
            this.cBtnSave.Click += new System.EventHandler(this.cBtnSave_Click);
            // 
            // cTextBoxDiscount
            // 
            this.cTextBoxDiscount.BackColor = System.Drawing.Color.White;
            this.cTextBoxDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxDiscount.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxDiscount.BorderRadius = 4;
            this.cTextBoxDiscount.BorderSize = 2;
            this.cTextBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxDiscount.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxDiscount.Location = new System.Drawing.Point(881, 146);
            this.cTextBoxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxDiscount.Multiline = false;
            this.cTextBoxDiscount.Name = "cTextBoxDiscount";
            this.cTextBoxDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxDiscount.PasswordChar = false;
            this.cTextBoxDiscount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxDiscount.PlaceholderText = "";
            this.cTextBoxDiscount.Size = new System.Drawing.Size(321, 47);
            this.cTextBoxDiscount.TabIndex = 32;
            this.cTextBoxDiscount.Texts = "";
            this.cTextBoxDiscount.UnderlinedStyle = false;
            // 
            // cTextBoxPriceAfterDiscount
            // 
            this.cTextBoxPriceAfterDiscount.BackColor = System.Drawing.Color.White;
            this.cTextBoxPriceAfterDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxPriceAfterDiscount.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxPriceAfterDiscount.BorderRadius = 4;
            this.cTextBoxPriceAfterDiscount.BorderSize = 2;
            this.cTextBoxPriceAfterDiscount.Enabled = false;
            this.cTextBoxPriceAfterDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxPriceAfterDiscount.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxPriceAfterDiscount.Location = new System.Drawing.Point(262, 211);
            this.cTextBoxPriceAfterDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxPriceAfterDiscount.Multiline = false;
            this.cTextBoxPriceAfterDiscount.Name = "cTextBoxPriceAfterDiscount";
            this.cTextBoxPriceAfterDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxPriceAfterDiscount.PasswordChar = false;
            this.cTextBoxPriceAfterDiscount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxPriceAfterDiscount.PlaceholderText = "";
            this.cTextBoxPriceAfterDiscount.Size = new System.Drawing.Size(249, 47);
            this.cTextBoxPriceAfterDiscount.TabIndex = 30;
            this.cTextBoxPriceAfterDiscount.Texts = "";
            this.cTextBoxPriceAfterDiscount.UnderlinedStyle = false;
            // 
            // cTextBoxSellingPrice
            // 
            this.cTextBoxSellingPrice.BackColor = System.Drawing.Color.White;
            this.cTextBoxSellingPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxSellingPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxSellingPrice.BorderRadius = 4;
            this.cTextBoxSellingPrice.BorderSize = 2;
            this.cTextBoxSellingPrice.Enabled = false;
            this.cTextBoxSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxSellingPrice.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxSellingPrice.Location = new System.Drawing.Point(191, 145);
            this.cTextBoxSellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxSellingPrice.Multiline = false;
            this.cTextBoxSellingPrice.Name = "cTextBoxSellingPrice";
            this.cTextBoxSellingPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxSellingPrice.PasswordChar = false;
            this.cTextBoxSellingPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxSellingPrice.PlaceholderText = "";
            this.cTextBoxSellingPrice.Size = new System.Drawing.Size(320, 47);
            this.cTextBoxSellingPrice.TabIndex = 25;
            this.cTextBoxSellingPrice.Texts = "";
            this.cTextBoxSellingPrice.UnderlinedStyle = false;
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
            this.cTextBoxIdBook.Location = new System.Drawing.Point(191, 50);
            this.cTextBoxIdBook.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxIdBook.Multiline = false;
            this.cTextBoxIdBook.Name = "cTextBoxIdBook";
            this.cTextBoxIdBook.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxIdBook.PasswordChar = false;
            this.cTextBoxIdBook.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxIdBook.PlaceholderText = "";
            this.cTextBoxIdBook.Size = new System.Drawing.Size(320, 47);
            this.cTextBoxIdBook.TabIndex = 7;
            this.cTextBoxIdBook.Texts = "";
            this.cTextBoxIdBook.UnderlinedStyle = false;
            // 
            // cTextBoxBookName
            // 
            this.cTextBoxBookName.BackColor = System.Drawing.Color.White;
            this.cTextBoxBookName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxBookName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxBookName.BorderRadius = 4;
            this.cTextBoxBookName.BorderSize = 2;
            this.cTextBoxBookName.Enabled = false;
            this.cTextBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxBookName.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBookName.Location = new System.Drawing.Point(881, 50);
            this.cTextBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxBookName.Multiline = false;
            this.cTextBoxBookName.Name = "cTextBoxBookName";
            this.cTextBoxBookName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxBookName.PasswordChar = false;
            this.cTextBoxBookName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxBookName.PlaceholderText = "";
            this.cTextBoxBookName.Size = new System.Drawing.Size(321, 47);
            this.cTextBoxBookName.TabIndex = 6;
            this.cTextBoxBookName.Texts = "";
            this.cTextBoxBookName.UnderlinedStyle = false;
            // 
            // FormDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1641, 925);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelheader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDiscount";
            this.Text = "FormDiscount";
            this.panelheader.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLisfOfDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox cTextBoxBoxSearch;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.ComboBox cbSort;
        private FontAwesome.Sharp.IconButton iBtnSort;
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomButton cBtnAdd;
        private CustomButton cBtnClear;
        private CustomButton cBtnSave;
        private CustomTextBox cTextBoxDiscount;
        private System.Windows.Forms.Label label9;
        private CustomTextBox cTextBoxPriceAfterDiscount;
        private System.Windows.Forms.Label label7;
        private CustomTextBox cTextBoxSellingPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLine;
        private CustomTextBox cTextBoxIdBook;
        private System.Windows.Forms.Label label8;
        private CustomTextBox cTextBoxBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewLisfOfDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealPrice;
    }
}