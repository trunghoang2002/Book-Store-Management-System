namespace QLNS.Views.ViewRevenue
{
    partial class FormRevenue
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
            this.panelMOrder = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iBtnRevenueFromDay = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerRevenueOfDay = new System.Windows.Forms.DateTimePicker();
            this.iBtnRevenueOfDay = new FontAwesome.Sharp.IconButton();
            this.customPanel2 = new QLNS.CustomPanel();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.customPanel1 = new QLNS.CustomPanel();
            this.lbTotalBSold = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.panelMOrder.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1215, 16);
            this.panel1.TabIndex = 4;
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
            this.dataGridViewBookOrder.ColumnHeadersHeight = 70;
            this.dataGridViewBookOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.BookID,
            this.BookName,
            this.Amount,
            this.Date,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(53, 308);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(1109, 287);
            this.dataGridViewBookOrder.TabIndex = 31;
            // 
            // panelMOrder
            // 
            this.panelMOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelMOrder.Controls.Add(this.dateTimePicker2);
            this.panelMOrder.Controls.Add(this.label1);
            this.panelMOrder.Controls.Add(this.dateTimePicker1);
            this.panelMOrder.Controls.Add(this.iBtnRevenueFromDay);
            this.panelMOrder.Controls.Add(this.dateTimePickerRevenueOfDay);
            this.panelMOrder.Controls.Add(this.iBtnRevenueOfDay);
            this.panelMOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMOrder.Location = new System.Drawing.Point(53, 169);
            this.panelMOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMOrder.Name = "panelMOrder";
            this.panelMOrder.Size = new System.Drawing.Size(1109, 134);
            this.panelMOrder.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(694, 83);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(363, 39);
            this.dateTimePicker2.TabIndex = 31;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(363, 39);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // iBtnRevenueFromDay
            // 
            this.iBtnRevenueFromDay.FlatAppearance.BorderSize = 0;
            this.iBtnRevenueFromDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnRevenueFromDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnRevenueFromDay.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.iBtnRevenueFromDay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnRevenueFromDay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnRevenueFromDay.IconSize = 30;
            this.iBtnRevenueFromDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnRevenueFromDay.Location = new System.Drawing.Point(51, 80);
            this.iBtnRevenueFromDay.Name = "iBtnRevenueFromDay";
            this.iBtnRevenueFromDay.Size = new System.Drawing.Size(213, 39);
            this.iBtnRevenueFromDay.TabIndex = 28;
            this.iBtnRevenueFromDay.Text = "Revenue from day : ";
            this.iBtnRevenueFromDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnRevenueFromDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnRevenueFromDay.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerRevenueOfDay
            // 
            this.dateTimePickerRevenueOfDay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRevenueOfDay.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerRevenueOfDay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerRevenueOfDay.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerRevenueOfDay.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePickerRevenueOfDay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerRevenueOfDay.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerRevenueOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRevenueOfDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRevenueOfDay.Location = new System.Drawing.Point(270, 21);
            this.dateTimePickerRevenueOfDay.Name = "dateTimePickerRevenueOfDay";
            this.dateTimePickerRevenueOfDay.Size = new System.Drawing.Size(363, 39);
            this.dateTimePickerRevenueOfDay.TabIndex = 27;
            this.dateTimePickerRevenueOfDay.ValueChanged += new System.EventHandler(this.dateTimePickerRevenueOfDay_ValueChanged);
            // 
            // iBtnRevenueOfDay
            // 
            this.iBtnRevenueOfDay.FlatAppearance.BorderSize = 0;
            this.iBtnRevenueOfDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnRevenueOfDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnRevenueOfDay.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.iBtnRevenueOfDay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnRevenueOfDay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnRevenueOfDay.IconSize = 30;
            this.iBtnRevenueOfDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnRevenueOfDay.Location = new System.Drawing.Point(51, 21);
            this.iBtnRevenueOfDay.Name = "iBtnRevenueOfDay";
            this.iBtnRevenueOfDay.Size = new System.Drawing.Size(213, 39);
            this.iBtnRevenueOfDay.TabIndex = 26;
            this.iBtnRevenueOfDay.Text = "Revenue of day : ";
            this.iBtnRevenueOfDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnRevenueOfDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnRevenueOfDay.UseVisualStyleBackColor = true;
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
            this.customPanel2.Location = new System.Drawing.Point(738, 18);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(240, 140);
            this.customPanel2.TabIndex = 33;
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.BackColor = System.Drawing.Color.IndianRed;
            this.lbTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lbTotalRevenue.Location = new System.Drawing.Point(30, 70);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(26, 29);
            this.lbTotalRevenue.TabIndex = 3;
            this.lbTotalRevenue.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Revenue";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.IndianRed;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 35;
            this.iconPictureBox2.Location = new System.Drawing.Point(25, 14);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 5;
            this.customPanel1.Controls.Add(this.lbTotalBSold);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.iconPictureBox1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 30F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.customPanel1.Location = new System.Drawing.Point(314, 18);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(240, 140);
            this.customPanel1.TabIndex = 32;
            // 
            // lbTotalBSold
            // 
            this.lbTotalBSold.AutoSize = true;
            this.lbTotalBSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.lbTotalBSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBSold.ForeColor = System.Drawing.Color.White;
            this.lbTotalBSold.Location = new System.Drawing.Point(60, 70);
            this.lbTotalBSold.Name = "lbTotalBSold";
            this.lbTotalBSold.Size = new System.Drawing.Size(26, 29);
            this.lbTotalBSold.TabIndex = 2;
            this.lbTotalBSold.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Book Sold";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.iconPictureBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(27, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // BillID
            // 
            this.BillID.HeaderText = "Bill\'s ID";
            this.BillID.MinimumWidth = 6;
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "Book\'s ID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book\'s name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price(VND)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // FormRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 612);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.panelMOrder);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRevenue";
            this.Text = "FormManagementOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.panelMOrder.ResumeLayout(false);
            this.panelMOrder.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CustomPanel customPanel2;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label lbTotalBSold;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private System.Windows.Forms.Panel panelMOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton iBtnRevenueFromDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerRevenueOfDay;
        private FontAwesome.Sharp.IconButton iBtnRevenueOfDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}