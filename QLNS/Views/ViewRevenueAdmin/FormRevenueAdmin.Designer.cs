namespace QLNS.Views.ViewRevenueAdmin
{
    partial class FormRevenueAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRevenueAdmin));
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icbDetailBill = new FontAwesome.Sharp.IconButton();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbSalesman = new System.Windows.Forms.RadioButton();
            this.customPanel3 = new QLNS.CustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTotalProfit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customPanel1 = new QLNS.CustomPanel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel2 = new QLNS.CustomPanel();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.cBtnCustomOk = new QLNS.CustomButton();
            this.cBtnCustom = new QLNS.CustomButton();
            this.cBtnToday = new QLNS.CustomButton();
            this.cBtnLast7day = new QLNS.CustomButton();
            this.cBtnLast30day = new QLNS.CustomButton();
            this.cBtnThismonth = new QLNS.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpStartDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(44, 28);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(195, 38);
            this.dtpStartDate.TabIndex = 43;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpEndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(282, 28);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(195, 38);
            this.dtpEndDate.TabIndex = 45;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 16);
            this.panel1.TabIndex = 47;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.Location = new System.Drawing.Point(282, 21);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(195, 38);
            this.lbEndDate.TabIndex = 48;
            this.lbEndDate.Text = "27/05/2022";
            this.lbEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEndDate.Click += new System.EventHandler(this.lbEndDate_Click);
            // 
            // lbStartDate
            // 
            this.lbStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(44, 20);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(195, 38);
            this.lbStartDate.TabIndex = 50;
            this.lbStartDate.Text = "27/05/2022";
            this.lbStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStartDate.Click += new System.EventHandler(this.lbStartDate_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookOrder.ColumnHeadersHeight = 40;
            this.dataGridViewBookOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.CustomerName,
            this.Date,
            this.TotalPrice,
            this.StaffID,
            this.StaffName,
            this.PaymentMethod});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(49, 319);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(1257, 228);
            this.dataGridViewBookOrder.TabIndex = 54;
            // 
            // BillID
            // 
            this.BillID.HeaderText = "Bill\'s ID";
            this.BillID.MinimumWidth = 6;
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer\'s name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "Staff\'s ID";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // StaffName
            // 
            this.StaffName.HeaderText = "Staff\'s name";
            this.StaffName.MinimumWidth = 6;
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Payment method";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.icbDetailBill);
            this.groupBox1.Controls.Add(this.rbCategory);
            this.groupBox1.Controls.Add(this.rbBook);
            this.groupBox1.Controls.Add(this.rbSalesman);
            this.groupBox1.Location = new System.Drawing.Point(49, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1257, 73);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // icbDetailBill
            // 
            this.icbDetailBill.FlatAppearance.BorderSize = 0;
            this.icbDetailBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbDetailBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbDetailBill.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.icbDetailBill.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.icbDetailBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbDetailBill.IconSize = 32;
            this.icbDetailBill.Location = new System.Drawing.Point(0, 0);
            this.icbDetailBill.Name = "icbDetailBill";
            this.icbDetailBill.Size = new System.Drawing.Size(190, 73);
            this.icbDetailBill.TabIndex = 56;
            this.icbDetailBill.Text = "Detail Bill";
            this.icbDetailBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbDetailBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbDetailBill.UseVisualStyleBackColor = true;
            this.icbDetailBill.Click += new System.EventHandler(this.icbDetailBill_Click);
            // 
            // rbCategory
            // 
            this.rbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCategory.Image = ((System.Drawing.Image)(resources.GetObject("rbCategory.Image")));
            this.rbCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbCategory.Location = new System.Drawing.Point(1100, 8);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(165, 59);
            this.rbCategory.TabIndex = 2;
            this.rbCategory.Text = "Category";
            this.rbCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbCategory.UseVisualStyleBackColor = true;
            this.rbCategory.CheckedChanged += new System.EventHandler(this.rbCategory_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBook.Image = ((System.Drawing.Image)(resources.GetObject("rbBook.Image")));
            this.rbBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbBook.Location = new System.Drawing.Point(643, 9);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(139, 59);
            this.rbBook.TabIndex = 1;
            this.rbBook.Text = "Book";
            this.rbBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // rbSalesman
            // 
            this.rbSalesman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbSalesman.Checked = true;
            this.rbSalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSalesman.Image = ((System.Drawing.Image)(resources.GetObject("rbSalesman.Image")));
            this.rbSalesman.Location = new System.Drawing.Point(220, 8);
            this.rbSalesman.Name = "rbSalesman";
            this.rbSalesman.Size = new System.Drawing.Size(208, 59);
            this.rbSalesman.TabIndex = 0;
            this.rbSalesman.TabStop = true;
            this.rbSalesman.Text = "Sales man";
            this.rbSalesman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbSalesman.UseVisualStyleBackColor = true;
            this.rbSalesman.CheckedChanged += new System.EventHandler(this.rbSalesman_CheckedChanged);
            // 
            // customPanel3
            // 
            this.customPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel3.BackColor = System.Drawing.Color.Yellow;
            this.customPanel3.BorderRadius = 5;
            this.customPanel3.Controls.Add(this.pictureBox1);
            this.customPanel3.Controls.Add(this.lbTotalProfit);
            this.customPanel3.Controls.Add(this.label6);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 30F;
            this.customPanel3.GradientBottonColor = System.Drawing.Color.LimeGreen;
            this.customPanel3.GradientTopColor = System.Drawing.Color.LimeGreen;
            this.customPanel3.Location = new System.Drawing.Point(1006, 83);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(300, 140);
            this.customPanel3.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbTotalProfit
            // 
            this.lbTotalProfit.AutoSize = true;
            this.lbTotalProfit.BackColor = System.Drawing.Color.LimeGreen;
            this.lbTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProfit.ForeColor = System.Drawing.Color.White;
            this.lbTotalProfit.Location = new System.Drawing.Point(138, 70);
            this.lbTotalProfit.Name = "lbTotalProfit";
            this.lbTotalProfit.Size = new System.Drawing.Size(26, 29);
            this.lbTotalProfit.TabIndex = 3;
            this.lbTotalProfit.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LimeGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(83, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Profit";
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 5;
            this.customPanel1.Controls.Add(this.iconPictureBox4);
            this.customPanel1.Controls.Add(this.lbTotalBill);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 30F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.customPanel1.Location = new System.Drawing.Point(49, 83);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(300, 140);
            this.customPanel1.TabIndex = 51;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconPictureBox4.IconColor = System.Drawing.Color.White;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 35;
            this.iconPictureBox4.Location = new System.Drawing.Point(51, 14);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 3;
            this.iconPictureBox4.TabStop = false;
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.lbTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBill.ForeColor = System.Drawing.Color.White;
            this.lbTotalBill.Location = new System.Drawing.Point(132, 70);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(26, 29);
            this.lbTotalBill.TabIndex = 2;
            this.lbTotalBill.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Bill";
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 5;
            this.customPanel2.Controls.Add(this.lbTotalRevenue);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.iconPictureBox2);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 30F;
            this.customPanel2.GradientBottonColor = System.Drawing.Color.IndianRed;
            this.customPanel2.GradientTopColor = System.Drawing.Color.IndianRed;
            this.customPanel2.Location = new System.Drawing.Point(542, 83);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(300, 140);
            this.customPanel2.TabIndex = 52;
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.BackColor = System.Drawing.Color.IndianRed;
            this.lbTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lbTotalRevenue.Location = new System.Drawing.Point(138, 70);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(26, 29);
            this.lbTotalRevenue.TabIndex = 3;
            this.lbTotalRevenue.Text = "0";
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
            this.label3.Text = "Total Revenue";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.IndianRed;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconPictureBox2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 35;
            this.iconPictureBox2.Location = new System.Drawing.Point(25, 14);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // cBtnCustomOk
            // 
            this.cBtnCustomOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBtnCustomOk.BackColor = System.Drawing.Color.IndianRed;
            this.cBtnCustomOk.BackgroundColor = System.Drawing.Color.IndianRed;
            this.cBtnCustomOk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnCustomOk.BorderRadius = 1;
            this.cBtnCustomOk.BorderSize = 1;
            this.cBtnCustomOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnCustomOk.FlatAppearance.BorderSize = 0;
            this.cBtnCustomOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnCustomOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnCustomOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnCustomOk.Image = ((System.Drawing.Image)(resources.GetObject("cBtnCustomOk.Image")));
            this.cBtnCustomOk.Location = new System.Drawing.Point(496, 21);
            this.cBtnCustomOk.Name = "cBtnCustomOk";
            this.cBtnCustomOk.Size = new System.Drawing.Size(46, 40);
            this.cBtnCustomOk.TabIndex = 11;
            this.cBtnCustomOk.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnCustomOk.UseVisualStyleBackColor = false;
            // 
            // cBtnCustom
            // 
            this.cBtnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBtnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnCustom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnCustom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnCustom.BorderRadius = 1;
            this.cBtnCustom.BorderSize = 1;
            this.cBtnCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnCustom.FlatAppearance.BorderSize = 0;
            this.cBtnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnCustom.Location = new System.Drawing.Point(542, 21);
            this.cBtnCustom.Name = "cBtnCustom";
            this.cBtnCustom.Size = new System.Drawing.Size(150, 40);
            this.cBtnCustom.TabIndex = 10;
            this.cBtnCustom.Text = "Custom";
            this.cBtnCustom.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnCustom.UseVisualStyleBackColor = false;
            this.cBtnCustom.Click += new System.EventHandler(this.cBtnCustom_Click);
            // 
            // cBtnToday
            // 
            this.cBtnToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBtnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnToday.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnToday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnToday.BorderRadius = 1;
            this.cBtnToday.BorderSize = 1;
            this.cBtnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnToday.FlatAppearance.BorderSize = 0;
            this.cBtnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnToday.Location = new System.Drawing.Point(692, 21);
            this.cBtnToday.Name = "cBtnToday";
            this.cBtnToday.Size = new System.Drawing.Size(157, 40);
            this.cBtnToday.TabIndex = 9;
            this.cBtnToday.Text = "Today";
            this.cBtnToday.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnToday.UseVisualStyleBackColor = false;
            this.cBtnToday.Click += new System.EventHandler(this.cBtnToday_Click);
            // 
            // cBtnLast7day
            // 
            this.cBtnLast7day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBtnLast7day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnLast7day.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnLast7day.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnLast7day.BorderRadius = 1;
            this.cBtnLast7day.BorderSize = 1;
            this.cBtnLast7day.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnLast7day.FlatAppearance.BorderSize = 0;
            this.cBtnLast7day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnLast7day.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnLast7day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnLast7day.Location = new System.Drawing.Point(849, 21);
            this.cBtnLast7day.Name = "cBtnLast7day";
            this.cBtnLast7day.Size = new System.Drawing.Size(157, 40);
            this.cBtnLast7day.TabIndex = 8;
            this.cBtnLast7day.Text = "Lasts 7 days";
            this.cBtnLast7day.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnLast7day.UseVisualStyleBackColor = false;
            this.cBtnLast7day.Click += new System.EventHandler(this.cBtnLast7day_Click);
            // 
            // cBtnLast30day
            // 
            this.cBtnLast30day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBtnLast30day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnLast30day.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnLast30day.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnLast30day.BorderRadius = 1;
            this.cBtnLast30day.BorderSize = 1;
            this.cBtnLast30day.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnLast30day.FlatAppearance.BorderSize = 0;
            this.cBtnLast30day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnLast30day.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnLast30day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnLast30day.Location = new System.Drawing.Point(1006, 21);
            this.cBtnLast30day.Name = "cBtnLast30day";
            this.cBtnLast30day.Size = new System.Drawing.Size(157, 40);
            this.cBtnLast30day.TabIndex = 7;
            this.cBtnLast30day.Text = "Last 30 days";
            this.cBtnLast30day.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnLast30day.UseVisualStyleBackColor = false;
            this.cBtnLast30day.Click += new System.EventHandler(this.cBtnLast30day_Click);
            // 
            // cBtnThismonth
            // 
            this.cBtnThismonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBtnThismonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnThismonth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cBtnThismonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnThismonth.BorderRadius = 1;
            this.cBtnThismonth.BorderSize = 1;
            this.cBtnThismonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnThismonth.FlatAppearance.BorderSize = 0;
            this.cBtnThismonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnThismonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnThismonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnThismonth.Location = new System.Drawing.Point(1163, 21);
            this.cBtnThismonth.Name = "cBtnThismonth";
            this.cBtnThismonth.Size = new System.Drawing.Size(157, 40);
            this.cBtnThismonth.TabIndex = 6;
            this.cBtnThismonth.Text = "This month";
            this.cBtnThismonth.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnThismonth.UseVisualStyleBackColor = false;
            this.cBtnThismonth.Click += new System.EventHandler(this.cBtnThismonth_Click);
            // 
            // FormRevenueAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 562);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cBtnCustomOk);
            this.Controls.Add(this.cBtnCustom);
            this.Controls.Add(this.cBtnToday);
            this.Controls.Add(this.cBtnLast7day);
            this.Controls.Add(this.cBtnLast30day);
            this.Controls.Add(this.cBtnThismonth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRevenueAdmin";
            this.Text = "-";
            this.Load += new System.EventHandler(this.FormRevenueAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton cBtnCustomOk;
        private CustomButton cBtnCustom;
        private CustomButton cBtnToday;
        private CustomButton cBtnLast7day;
        private CustomButton cBtnLast30day;
        private CustomButton cBtnThismonth;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.Label label2;
        private CustomPanel customPanel2;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private CustomPanel customPanel3;
        private System.Windows.Forms.Label lbTotalProfit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbSalesman;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconButton icbDetailBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
    }
}