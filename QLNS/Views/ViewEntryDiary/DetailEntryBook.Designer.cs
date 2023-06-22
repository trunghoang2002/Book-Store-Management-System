namespace QLNS.Views.ViewEntryDiary
{
    partial class DetailEntryBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailEntryBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cTextIdStaff = new QLNS.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cTextStaffName = new QLNS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEntry = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCloseEditEntryDiary = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbListOfBook = new System.Windows.Forms.Label();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel1 = new QLNS.CustomPanel();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.cTextIdStaff);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cTextStaffName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 119);
            this.panel1.TabIndex = 0;
            // 
            // cTextIdStaff
            // 
            this.cTextIdStaff.BackColor = System.Drawing.Color.White;
            this.cTextIdStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cTextIdStaff.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextIdStaff.BorderRadius = 4;
            this.cTextIdStaff.BorderSize = 2;
            this.cTextIdStaff.Enabled = false;
            this.cTextIdStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextIdStaff.ForeColor = System.Drawing.Color.Black;
            this.cTextIdStaff.Location = new System.Drawing.Point(235, 11);
            this.cTextIdStaff.Margin = new System.Windows.Forms.Padding(4);
            this.cTextIdStaff.Multiline = false;
            this.cTextIdStaff.Name = "cTextIdStaff";
            this.cTextIdStaff.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextIdStaff.PasswordChar = false;
            this.cTextIdStaff.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextIdStaff.PlaceholderText = "";
            this.cTextIdStaff.Size = new System.Drawing.Size(360, 44);
            this.cTextIdStaff.TabIndex = 5;
            this.cTextIdStaff.Texts = "";
            this.cTextIdStaff.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(28, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID Staff  : ";
            // 
            // cTextStaffName
            // 
            this.cTextStaffName.BackColor = System.Drawing.Color.White;
            this.cTextStaffName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cTextStaffName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextStaffName.BorderRadius = 4;
            this.cTextStaffName.BorderSize = 2;
            this.cTextStaffName.Enabled = false;
            this.cTextStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextStaffName.ForeColor = System.Drawing.Color.Black;
            this.cTextStaffName.Location = new System.Drawing.Point(235, 66);
            this.cTextStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.cTextStaffName.Multiline = false;
            this.cTextStaffName.Name = "cTextStaffName";
            this.cTextStaffName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextStaffName.PasswordChar = false;
            this.cTextStaffName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextStaffName.PlaceholderText = "";
            this.cTextStaffName.Size = new System.Drawing.Size(360, 44);
            this.cTextStaffName.TabIndex = 1;
            this.cTextStaffName.Texts = "";
            this.cTextStaffName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Name : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePickerEntry);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 103);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(28, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Entry : ";
            // 
            // dateTimePickerEntry
            // 
            this.dateTimePickerEntry.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEntry.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerEntry.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerEntry.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerEntry.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePickerEntry.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerEntry.Enabled = false;
            this.dateTimePickerEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEntry.Location = new System.Drawing.Point(235, 33);
            this.dateTimePickerEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEntry.Name = "dateTimePickerEntry";
            this.dateTimePickerEntry.Size = new System.Drawing.Size(360, 39);
            this.dateTimePickerEntry.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCloseEditEntryDiary);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 62);
            this.panel3.TabIndex = 2;
            // 
            // btnCloseEditEntryDiary
            // 
            this.btnCloseEditEntryDiary.BackColor = System.Drawing.Color.White;
            this.btnCloseEditEntryDiary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseEditEntryDiary.FlatAppearance.BorderSize = 0;
            this.btnCloseEditEntryDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEditEntryDiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseEditEntryDiary.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseEditEntryDiary.Image")));
            this.btnCloseEditEntryDiary.Location = new System.Drawing.Point(853, 16);
            this.btnCloseEditEntryDiary.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseEditEntryDiary.Name = "btnCloseEditEntryDiary";
            this.btnCloseEditEntryDiary.Size = new System.Drawing.Size(30, 30);
            this.btnCloseEditEntryDiary.TabIndex = 3;
            this.btnCloseEditEntryDiary.UseVisualStyleBackColor = false;
            this.btnCloseEditEntryDiary.Click += new System.EventHandler(this.btnCloseEditEntryDiary_Click);
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
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Detail Entry Diary";
            // 
            // lbLine
            // 
            this.lbLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbLine.Location = new System.Drawing.Point(33, 289);
            this.lbLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(700, 2);
            this.lbLine.TabIndex = 5;
            this.lbLine.Text = "line";
            // 
            // lbListOfBook
            // 
            this.lbListOfBook.AutoSize = true;
            this.lbListOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListOfBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbListOfBook.Location = new System.Drawing.Point(31, 323);
            this.lbListOfBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListOfBook.Name = "lbListOfBook";
            this.lbListOfBook.Size = new System.Drawing.Size(118, 25);
            this.lbListOfBook.TabIndex = 9;
            this.lbListOfBook.Text = "List Of Book";
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewBookOrder.ColumnHeadersHeight = 40;
            this.dataGridViewBookOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.Quantity,
            this.CostPrice});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(33, 374);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(850, 208);
            this.dataGridViewBookOrder.TabIndex = 21;
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
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "Cost Price(VND)";
            this.CostPrice.MinimumWidth = 6;
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 6;
            this.customPanel1.Controls.Add(this.lbTotalCost);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.customPanel1.Location = new System.Drawing.Point(212, 599);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(450, 62);
            this.customPanel1.TabIndex = 16;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.Location = new System.Drawing.Point(245, 12);
            this.lbTotalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(201, 36);
            this.lbTotalCost.TabIndex = 1;
            this.lbTotalCost.Text = "0.0";
            this.lbTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Cost ( VND ) : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailEditEntryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 751);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.lbListOfBook);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailEditEntryBook";
            this.ShowInTaskbar = false;
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.DetailEditEntryBook_Load);
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
        private System.Windows.Forms.DateTimePicker dateTimePickerEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbListOfBook;
        private CustomTextBox cTextStaffName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalCost;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Button btnCloseEditEntryDiary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private CustomTextBox cTextIdStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
    }
}