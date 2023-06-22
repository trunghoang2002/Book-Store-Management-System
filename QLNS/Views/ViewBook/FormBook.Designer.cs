namespace QLNS.Views.ViewBook
{
    partial class FormBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMOrder = new System.Windows.Forms.Panel();
            this.cTextBoxSearch = new QLNS.CustomTextBox();
            this.pictureBoxCategory = new System.Windows.Forms.PictureBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.iBtnSort = new FontAwesome.Sharp.IconButton();
            this.iBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMOrder
            // 
            this.panelMOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelMOrder.Controls.Add(this.cTextBoxSearch);
            this.panelMOrder.Controls.Add(this.pictureBoxCategory);
            this.panelMOrder.Controls.Add(this.cbCategory);
            this.panelMOrder.Controls.Add(this.lbCategory);
            this.panelMOrder.Controls.Add(this.iBtnSearch);
            this.panelMOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMOrder.Location = new System.Drawing.Point(56, 47);
            this.panelMOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMOrder.Name = "panelMOrder";
            this.panelMOrder.Size = new System.Drawing.Size(997, 88);
            this.panelMOrder.TabIndex = 25;
            // 
            // cTextBoxSearch
            // 
            this.cTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBoxSearch.BackColor = System.Drawing.Color.White;
            this.cTextBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextBoxSearch.BorderRadius = 4;
            this.cTextBoxSearch.BorderSize = 2;
            this.cTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxSearch.Location = new System.Drawing.Point(607, 25);
            this.cTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxSearch.Multiline = false;
            this.cTextBoxSearch.Name = "cTextBoxSearch";
            this.cTextBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxSearch.PasswordChar = false;
            this.cTextBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxSearch.PlaceholderText = "";
            this.cTextBoxSearch.Size = new System.Drawing.Size(300, 47);
            this.cTextBoxSearch.TabIndex = 26;
            this.cTextBoxSearch.Texts = "";
            this.cTextBoxSearch.UnderlinedStyle = false;
            // 
            // pictureBoxCategory
            // 
            this.pictureBoxCategory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategory.Image")));
            this.pictureBoxCategory.Location = new System.Drawing.Point(20, 30);
            this.pictureBoxCategory.Name = "pictureBoxCategory";
            this.pictureBoxCategory.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxCategory.TabIndex = 24;
            this.pictureBoxCategory.TabStop = false;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(180, 33);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(245, 39);
            this.cbCategory.TabIndex = 22;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(55, 4);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(122, 82);
            this.lbCategory.TabIndex = 23;
            this.lbCategory.Text = "Category";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.IconSize = 30;
            this.iBtnSearch.Location = new System.Drawing.Point(914, 25);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(65, 47);
            this.iBtnSearch.TabIndex = 20;
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 42);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.cbSort);
            this.panel2.Controls.Add(this.iBtnSort);
            this.panel2.Controls.Add(this.iBtnEdit);
            this.panel2.Controls.Add(this.iBtnDelete);
            this.panel2.Controls.Add(this.iBtnAdd);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(56, 674);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 88);
            this.panel2.TabIndex = 26;
            // 
            // cbSort
            // 
            this.cbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(749, 24);
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
            this.iBtnSort.Location = new System.Drawing.Point(630, 3);
            this.iBtnSort.Name = "iBtnSort";
            this.iBtnSort.Size = new System.Drawing.Size(113, 83);
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
            this.iBtnEdit.Location = new System.Drawing.Point(352, 2);
            this.iBtnEdit.Name = "iBtnEdit";
            this.iBtnEdit.Size = new System.Drawing.Size(131, 83);
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
            this.iBtnDelete.Location = new System.Drawing.Point(202, 2);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(144, 83);
            this.iBtnDelete.TabIndex = 18;
            this.iBtnDelete.Text = "Delete";
            this.iBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // iBtnAdd
            // 
            this.iBtnAdd.FlatAppearance.BorderSize = 0;
            this.iBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iBtnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAdd.IconSize = 30;
            this.iBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd.Location = new System.Drawing.Point(52, 3);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Size = new System.Drawing.Size(144, 83);
            this.iBtnAdd.TabIndex = 17;
            this.iBtnAdd.Text = "Add";
            this.iBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAdd.UseVisualStyleBackColor = true;
            this.iBtnAdd.Click += new System.EventHandler(this.iBtnAdd_Click);
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
            this.RemainingAmount,
            this.CostPrice,
            this.SellingPrice,
            this.Discount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(56, 140);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(997, 529);
            this.dataGridViewBookOrder.TabIndex = 27;
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
            // RemainingAmount
            // 
            this.RemainingAmount.HeaderText = "Remaining amount";
            this.RemainingAmount.MinimumWidth = 6;
            this.RemainingAmount.Name = "RemainingAmount";
            this.RemainingAmount.ReadOnly = true;
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
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 845);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.panelMOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBook";
            this.Text = "Book";
            this.panelMOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMOrder;
        private CustomTextBox cTextBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbCategory;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbSort;
        private FontAwesome.Sharp.IconButton iBtnSort;
        private FontAwesome.Sharp.IconButton iBtnEdit;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private FontAwesome.Sharp.IconButton iBtnAdd;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}