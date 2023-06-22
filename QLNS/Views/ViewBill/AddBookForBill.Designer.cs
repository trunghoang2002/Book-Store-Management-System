namespace QLNS.Views.ViewBill
{
    partial class AddBookForBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.pictureBoxCategory = new System.Windows.Forms.PictureBox();
            this.cBtnCancel = new QLNS.CustomButton();
            this.cBtnAddBook = new QLNS.CustomButton();
            this.cTextBoxSearch = new QLNS.CustomTextBox();
            this.cTextBoxQuantity = new QLNS.CustomTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Book";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1241, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 88);
            this.panel1.TabIndex = 3;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.IconSize = 30;
            this.iBtnSearch.Location = new System.Drawing.Point(1213, 110);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(47, 44);
            this.iBtnSearch.TabIndex = 7;
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // dataGridViewBookOrder
            // 
            this.dataGridViewBookOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dataGridViewBookOrder.ColumnHeadersHeight = 70;
            this.dataGridViewBookOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Book,
            this.TitleBook,
            this.Author,
            this.Category,
            this.Publisher,
            this.PublishingYear,
            this.Edition,
            this.RemainingAmount,
            this.OriginalPrice,
            this.Discount,
            this.RealPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(28, 164);
            this.dataGridViewBookOrder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewBookOrder.MultiSelect = false;
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(1243, 395);
            this.dataGridViewBookOrder.TabIndex = 14;
            // 
            // ID_Book
            // 
            this.ID_Book.HeaderText = "Book\'s ID";
            this.ID_Book.MinimumWidth = 6;
            this.ID_Book.Name = "ID_Book";
            this.ID_Book.ReadOnly = true;
            this.ID_Book.Width = 131;
            // 
            // TitleBook
            // 
            this.TitleBook.HeaderText = "Book\'s name";
            this.TitleBook.MinimumWidth = 6;
            this.TitleBook.Name = "TitleBook";
            this.TitleBook.ReadOnly = true;
            this.TitleBook.Width = 164;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 111;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 139;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.MinimumWidth = 6;
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 144;
            // 
            // PublishingYear
            // 
            this.PublishingYear.HeaderText = "Publishing year";
            this.PublishingYear.MinimumWidth = 6;
            this.PublishingYear.Name = "PublishingYear";
            this.PublishingYear.ReadOnly = true;
            this.PublishingYear.Width = 189;
            // 
            // Edition
            // 
            this.Edition.HeaderText = "Edition";
            this.Edition.MinimumWidth = 6;
            this.Edition.Name = "Edition";
            this.Edition.ReadOnly = true;
            this.Edition.Width = 117;
            // 
            // RemainingAmount
            // 
            this.RemainingAmount.HeaderText = "Remaining amount";
            this.RemainingAmount.MinimumWidth = 6;
            this.RemainingAmount.Name = "RemainingAmount";
            this.RemainingAmount.ReadOnly = true;
            this.RemainingAmount.Width = 221;
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.HeaderText = "Original price(VND)";
            this.OriginalPrice.MinimumWidth = 6;
            this.OriginalPrice.Name = "OriginalPrice";
            this.OriginalPrice.ReadOnly = true;
            this.OriginalPrice.Width = 230;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount(%)";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 173;
            // 
            // RealPrice
            // 
            this.RealPrice.HeaderText = "Real price(VND)";
            this.RealPrice.MinimumWidth = 6;
            this.RealPrice.Name = "RealPrice";
            this.RealPrice.ReadOnly = true;
            this.RealPrice.Width = 199;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Category : ";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(205, 122);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(237, 37);
            this.cbCategory.TabIndex = 20;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // pictureBoxCategory
            // 
            this.pictureBoxCategory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategory.Image")));
            this.pictureBoxCategory.Location = new System.Drawing.Point(29, 125);
            this.pictureBoxCategory.Name = "pictureBoxCategory";
            this.pictureBoxCategory.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxCategory.TabIndex = 25;
            this.pictureBoxCategory.TabStop = false;
            // 
            // cBtnCancel
            // 
            this.cBtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.cBtnCancel.BackgroundColor = System.Drawing.Color.IndianRed;
            this.cBtnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnCancel.BorderRadius = 5;
            this.cBtnCancel.BorderSize = 0;
            this.cBtnCancel.FlatAppearance.BorderSize = 0;
            this.cBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnCancel.ForeColor = System.Drawing.Color.White;
            this.cBtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnCancel.Location = new System.Drawing.Point(655, 657);
            this.cBtnCancel.Name = "cBtnCancel";
            this.cBtnCancel.Size = new System.Drawing.Size(118, 40);
            this.cBtnCancel.TabIndex = 13;
            this.cBtnCancel.Text = "Cancel";
            this.cBtnCancel.TextColor = System.Drawing.Color.White;
            this.cBtnCancel.UseVisualStyleBackColor = false;
            this.cBtnCancel.Click += new System.EventHandler(this.cBtnCancel_Click);
            // 
            // cBtnAddBook
            // 
            this.cBtnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnAddBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnAddBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnAddBook.BorderRadius = 5;
            this.cBtnAddBook.BorderSize = 0;
            this.cBtnAddBook.FlatAppearance.BorderSize = 0;
            this.cBtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnAddBook.ForeColor = System.Drawing.Color.White;
            this.cBtnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnAddBook.Location = new System.Drawing.Point(485, 657);
            this.cBtnAddBook.Name = "cBtnAddBook";
            this.cBtnAddBook.Size = new System.Drawing.Size(118, 40);
            this.cBtnAddBook.TabIndex = 12;
            this.cBtnAddBook.Text = "Add";
            this.cBtnAddBook.TextColor = System.Drawing.Color.White;
            this.cBtnAddBook.UseVisualStyleBackColor = false;
            this.cBtnAddBook.Click += new System.EventHandler(this.cBtnAddBook_Click);
            // 
            // cTextBoxSearch
            // 
            this.cTextBoxSearch.BackColor = System.Drawing.Color.White;
            this.cTextBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxSearch.BorderRadius = 4;
            this.cTextBoxSearch.BorderSize = 2;
            this.cTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxSearch.Location = new System.Drawing.Point(768, 110);
            this.cTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxSearch.Multiline = false;
            this.cTextBoxSearch.Name = "cTextBoxSearch";
            this.cTextBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxSearch.PasswordChar = false;
            this.cTextBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxSearch.PlaceholderText = "";
            this.cTextBoxSearch.Size = new System.Drawing.Size(438, 44);
            this.cTextBoxSearch.TabIndex = 9;
            this.cTextBoxSearch.Texts = "";
            this.cTextBoxSearch.UnderlinedStyle = false;
            // 
            // cTextBoxQuantity
            // 
            this.cTextBoxQuantity.BackColor = System.Drawing.Color.White;
            this.cTextBoxQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxQuantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxQuantity.BorderRadius = 4;
            this.cTextBoxQuantity.BorderSize = 2;
            this.cTextBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cTextBoxQuantity.Location = new System.Drawing.Point(485, 589);
            this.cTextBoxQuantity.Margin = new System.Windows.Forms.Padding(7);
            this.cTextBoxQuantity.Multiline = false;
            this.cTextBoxQuantity.Name = "cTextBoxQuantity";
            this.cTextBoxQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxQuantity.PasswordChar = false;
            this.cTextBoxQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxQuantity.PlaceholderText = "";
            this.cTextBoxQuantity.Size = new System.Drawing.Size(288, 44);
            this.cTextBoxQuantity.TabIndex = 8;
            this.cTextBoxQuantity.Texts = "";
            this.cTextBoxQuantity.UnderlinedStyle = false;
            // 
            // AddBookForBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 754);
            this.Controls.Add(this.pictureBoxCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.cBtnCancel);
            this.Controls.Add(this.cBtnAddBook);
            this.Controls.Add(this.cTextBoxSearch);
            this.Controls.Add(this.cTextBoxQuantity);
            this.Controls.Add(this.iBtnSearch);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddBookForBill";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OrderBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private CustomTextBox cTextBoxSearch;
        private CustomButton cBtnAddBook;
        private CustomButton cBtnCancel;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private CustomTextBox cTextBoxQuantity;
        private System.Windows.Forms.PictureBox pictureBoxCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealPrice;
    }
}