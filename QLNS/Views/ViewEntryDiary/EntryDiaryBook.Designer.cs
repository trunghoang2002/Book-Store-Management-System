namespace QLNS.Views.ViewEntryDiary
{
    partial class EntryDiaryBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.IDStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerSecond = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iBtnDetail = new FontAwesome.Sharp.IconButton();
            this.cTextNameStaff = new QLNS.CustomTextBox();
            this.customPanel1 = new QLNS.CustomPanel();
            this.lbTotalPurcharedB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.customPanel2 = new QLNS.CustomPanel();
            this.lbExpense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 16);
            this.panel1.TabIndex = 36;
            // 
            // dataGridViewBookOrder
            // 
            this.dataGridViewBookOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBookOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookOrder.ColumnHeadersHeight = 40;
            this.dataGridViewBookOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStaff,
            this.NameStaff,
            this.Date,
            this.TotalQuantity,
            this.TotalCost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(60, 266);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(1109, 348);
            this.dataGridViewBookOrder.TabIndex = 37;
            // 
            // IDStaff
            // 
            this.IDStaff.HeaderText = "Staff\'s ID";
            this.IDStaff.MinimumWidth = 6;
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.ReadOnly = true;
            // 
            // NameStaff
            // 
            this.NameStaff.HeaderText = "Staff\'s name";
            this.NameStaff.MinimumWidth = 6;
            this.NameStaff.Name = "NameStaff";
            this.NameStaff.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date entry";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.HeaderText = "Total quantity";
            this.TotalQuantity.MinimumWidth = 6;
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total cost(VND)";
            this.TotalCost.MinimumWidth = 6;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cTextNameStaff);
            this.groupBox1.Controls.Add(this.iBtnSearch);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.dateTimePickerSecond);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerFirst);
            this.groupBox1.Location = new System.Drawing.Point(60, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 83);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.IconSize = 30;
            this.iBtnSearch.Location = new System.Drawing.Point(1049, 18);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(49, 47);
            this.iBtnSearch.TabIndex = 46;
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(5, 18);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(65, 53);
            this.iconButton1.TabIndex = 45;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerSecond
            // 
            this.dateTimePickerSecond.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSecond.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerSecond.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerSecond.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerSecond.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePickerSecond.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSecond.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSecond.Location = new System.Drawing.Point(358, 26);
            this.dateTimePickerSecond.Name = "dateTimePickerSecond";
            this.dateTimePickerSecond.Size = new System.Drawing.Size(225, 39);
            this.dateTimePickerSecond.TabIndex = 44;
            this.dateTimePickerSecond.ValueChanged += new System.EventHandler(this.dateTimePickerSecond_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(309, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "To";
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFirst.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerFirst.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerFirst.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerFirst.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePickerFirst.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFirst.Location = new System.Drawing.Point(78, 26);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(225, 39);
            this.dateTimePickerFirst.TabIndex = 42;
            this.dateTimePickerFirst.ValueChanged += new System.EventHandler(this.dateTimePickerFirst_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.iBtnDelete);
            this.groupBox2.Controls.Add(this.iBtnDetail);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(60, 622);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1109, 80);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.FlatAppearance.BorderSize = 0;
            this.iBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnDelete.IconColor = System.Drawing.Color.Black;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.IconSize = 30;
            this.iBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelete.Location = new System.Drawing.Point(173, 0);
            this.iBtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(144, 80);
            this.iBtnDelete.TabIndex = 21;
            this.iBtnDelete.Text = "Delete";
            this.iBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // iBtnDetail
            // 
            this.iBtnDetail.FlatAppearance.BorderSize = 0;
            this.iBtnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDetail.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iBtnDetail.IconColor = System.Drawing.Color.Black;
            this.iBtnDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDetail.IconSize = 30;
            this.iBtnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDetail.Location = new System.Drawing.Point(21, 0);
            this.iBtnDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iBtnDetail.Name = "iBtnDetail";
            this.iBtnDetail.Size = new System.Drawing.Size(144, 80);
            this.iBtnDetail.TabIndex = 20;
            this.iBtnDetail.Text = "Detail";
            this.iBtnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDetail.UseVisualStyleBackColor = true;
            this.iBtnDetail.Click += new System.EventHandler(this.iBtnDetail_Click);
            // 
            // cTextNameStaff
            // 
            this.cTextNameStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextNameStaff.BackColor = System.Drawing.Color.White;
            this.cTextNameStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextNameStaff.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextNameStaff.BorderRadius = 4;
            this.cTextNameStaff.BorderSize = 2;
            this.cTextNameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextNameStaff.ForeColor = System.Drawing.Color.Black;
            this.cTextNameStaff.Location = new System.Drawing.Point(754, 18);
            this.cTextNameStaff.Margin = new System.Windows.Forms.Padding(4);
            this.cTextNameStaff.Multiline = false;
            this.cTextNameStaff.Name = "cTextNameStaff";
            this.cTextNameStaff.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextNameStaff.PasswordChar = false;
            this.cTextNameStaff.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextNameStaff.PlaceholderText = "";
            this.cTextNameStaff.Size = new System.Drawing.Size(288, 47);
            this.cTextNameStaff.TabIndex = 47;
            this.cTextNameStaff.Texts = "";
            this.cTextNameStaff.UnderlinedStyle = false;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 5;
            this.customPanel1.Controls.Add(this.lbTotalPurcharedB);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.iconPictureBox1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 30F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.customPanel1.Location = new System.Drawing.Point(246, 22);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(300, 140);
            this.customPanel1.TabIndex = 38;
            // 
            // lbTotalPurcharedB
            // 
            this.lbTotalPurcharedB.AutoSize = true;
            this.lbTotalPurcharedB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.lbTotalPurcharedB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPurcharedB.ForeColor = System.Drawing.Color.White;
            this.lbTotalPurcharedB.Location = new System.Drawing.Point(132, 70);
            this.lbTotalPurcharedB.Name = "lbTotalPurcharedB";
            this.lbTotalPurcharedB.Size = new System.Drawing.Size(26, 29);
            this.lbTotalPurcharedB.TabIndex = 2;
            this.lbTotalPurcharedB.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchased book";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(27, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 5;
            this.customPanel2.Controls.Add(this.lbExpense);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.iconPictureBox2);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 30F;
            this.customPanel2.GradientBottonColor = System.Drawing.Color.IndianRed;
            this.customPanel2.GradientTopColor = System.Drawing.Color.IndianRed;
            this.customPanel2.Location = new System.Drawing.Point(746, 22);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(300, 140);
            this.customPanel2.TabIndex = 39;
            // 
            // lbExpense
            // 
            this.lbExpense.AutoSize = true;
            this.lbExpense.BackColor = System.Drawing.Color.IndianRed;
            this.lbExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpense.ForeColor = System.Drawing.Color.White;
            this.lbExpense.Location = new System.Drawing.Point(138, 70);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(26, 29);
            this.lbExpense.TabIndex = 3;
            this.lbExpense.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Expense";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.IndianRed;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.iconPictureBox2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 35;
            this.iconPictureBox2.Location = new System.Drawing.Point(25, 14);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // EntryDiaryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EntryDiaryBook";
            this.Text = "FormExpense";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label lbTotalPurcharedB;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbExpense;
        private CustomPanel customPanel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomTextBox cTextNameStaff;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private FontAwesome.Sharp.IconButton iBtnDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
    }
}