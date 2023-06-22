namespace QLNS.Views.ViewExpense
{
    partial class FormExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpense));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerSecond = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbStocker = new System.Windows.Forms.RadioButton();
            this.customPanel1 = new QLNS.CustomPanel();
            this.lbTotalPurcharedBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.customPanel2 = new QLNS.CustomPanel();
            this.lbTotalExpense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.BookID,
            this.BookName,
            this.Amount,
            this.TotalCost,
            this.Date,
            this.StaffID,
            this.StaffName});
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
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(1109, 328);
            this.dataGridViewBookOrder.TabIndex = 37;
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
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total cost";
            this.TotalCost.MinimumWidth = 6;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date entry";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.dateTimePickerSecond);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerFirst);
            this.groupBox1.Controls.Add(this.rbCategory);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rbBook);
            this.groupBox1.Controls.Add(this.rbStocker);
            this.groupBox1.Location = new System.Drawing.Point(60, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 83);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
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
            // rbCategory
            // 
            this.rbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCategory.ForeColor = System.Drawing.Color.Black;
            this.rbCategory.Image = ((System.Drawing.Image)(resources.GetObject("rbCategory.Image")));
            this.rbCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbCategory.Location = new System.Drawing.Point(951, 14);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(165, 59);
            this.rbCategory.TabIndex = 2;
            this.rbCategory.Text = "Category";
            this.rbCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbCategory.UseVisualStyleBackColor = true;
            this.rbCategory.CheckedChanged += new System.EventHandler(this.rbCategory_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Image = ((System.Drawing.Image)(resources.GetObject("radioButton3.Image")));
            this.radioButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton3.Location = new System.Drawing.Point(951, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(165, 59);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Category";
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbBook
            // 
            this.rbBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBook.ForeColor = System.Drawing.Color.Black;
            this.rbBook.Image = ((System.Drawing.Image)(resources.GetObject("rbBook.Image")));
            this.rbBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbBook.Location = new System.Drawing.Point(754, 14);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(139, 59);
            this.rbBook.TabIndex = 1;
            this.rbBook.Text = "Book";
            this.rbBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // rbStocker
            // 
            this.rbStocker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbStocker.Checked = true;
            this.rbStocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStocker.ForeColor = System.Drawing.Color.Black;
            this.rbStocker.Image = ((System.Drawing.Image)(resources.GetObject("rbStocker.Image")));
            this.rbStocker.Location = new System.Drawing.Point(521, 14);
            this.rbStocker.Name = "rbStocker";
            this.rbStocker.Size = new System.Drawing.Size(165, 59);
            this.rbStocker.TabIndex = 0;
            this.rbStocker.TabStop = true;
            this.rbStocker.Text = "Stocker";
            this.rbStocker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbStocker.UseVisualStyleBackColor = true;
            this.rbStocker.CheckedChanged += new System.EventHandler(this.rbStocker_CheckedChanged);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 5;
            this.customPanel1.Controls.Add(this.lbTotalPurcharedBook);
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
            // lbTotalPurcharedBook
            // 
            this.lbTotalPurcharedBook.AutoSize = true;
            this.lbTotalPurcharedBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.lbTotalPurcharedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPurcharedBook.ForeColor = System.Drawing.Color.White;
            this.lbTotalPurcharedBook.Location = new System.Drawing.Point(132, 70);
            this.lbTotalPurcharedBook.Name = "lbTotalPurcharedBook";
            this.lbTotalPurcharedBook.Size = new System.Drawing.Size(26, 29);
            this.lbTotalPurcharedBook.TabIndex = 2;
            this.lbTotalPurcharedBook.Text = "0";
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
            this.customPanel2.Controls.Add(this.lbTotalExpense);
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
            // lbTotalExpense
            // 
            this.lbTotalExpense.AutoSize = true;
            this.lbTotalExpense.BackColor = System.Drawing.Color.IndianRed;
            this.lbTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalExpense.ForeColor = System.Drawing.Color.White;
            this.lbTotalExpense.Location = new System.Drawing.Point(138, 70);
            this.lbTotalExpense.Name = "lbTotalExpense";
            this.lbTotalExpense.Size = new System.Drawing.Size(26, 29);
            this.lbTotalExpense.TabIndex = 3;
            this.lbTotalExpense.Text = "0";
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
            this.label3.Text = "Expense";
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
            // FormExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormExpense";
            this.Text = "FormExpense";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lbTotalPurcharedBook;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalExpense;
        private CustomPanel customPanel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbStocker;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
    }
}