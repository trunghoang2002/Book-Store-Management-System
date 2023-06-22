namespace QLNS.Views.ViewEntryBook
{
    partial class FormEntryBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntryBook));
            this.lbListOfBook = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBtnCancel = new QLNS.CustomButton();
            this.cBtnSaveAndPrint = new QLNS.CustomButton();
            this.cBtnRemoveBook = new QLNS.CustomButton();
            this.cBtnAddBook = new QLNS.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListOfBook
            // 
            this.lbListOfBook.AutoSize = true;
            this.lbListOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListOfBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbListOfBook.Location = new System.Drawing.Point(31, 136);
            this.lbListOfBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListOfBook.Name = "lbListOfBook";
            this.lbListOfBook.Size = new System.Drawing.Size(281, 32);
            this.lbListOfBook.TabIndex = 16;
            this.lbListOfBook.Text = "List Of Book To Entry";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(33, 22);
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
            this.label4.Location = new System.Drawing.Point(69, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Entry";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 78);
            this.panel3.TabIndex = 15;
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
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookOrder.ColumnHeadersHeight = 40;
            this.dataGridViewBookOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.Quantity,
            this.CostPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(30, 195);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(1019, 324);
            this.dataGridViewBookOrder.TabIndex = 18;
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
            // cBtnCancel
            // 
            this.cBtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cBtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.cBtnCancel.BackgroundColor = System.Drawing.Color.IndianRed;
            this.cBtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cBtnCancel.BorderRadius = 5;
            this.cBtnCancel.BorderSize = 0;
            this.cBtnCancel.FlatAppearance.BorderSize = 0;
            this.cBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnCancel.ForeColor = System.Drawing.Color.White;
            this.cBtnCancel.Location = new System.Drawing.Point(490, 550);
            this.cBtnCancel.Name = "cBtnCancel";
            this.cBtnCancel.Size = new System.Drawing.Size(209, 51);
            this.cBtnCancel.TabIndex = 35;
            this.cBtnCancel.Text = "Cancel";
            this.cBtnCancel.TextColor = System.Drawing.Color.White;
            this.cBtnCancel.UseVisualStyleBackColor = false;
            this.cBtnCancel.Click += new System.EventHandler(this.cBtnCancel_Click);
            // 
            // cBtnSaveAndPrint
            // 
            this.cBtnSaveAndPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cBtnSaveAndPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnSaveAndPrint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnSaveAndPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cBtnSaveAndPrint.BorderRadius = 5;
            this.cBtnSaveAndPrint.BorderSize = 0;
            this.cBtnSaveAndPrint.FlatAppearance.BorderSize = 0;
            this.cBtnSaveAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnSaveAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnSaveAndPrint.ForeColor = System.Drawing.Color.White;
            this.cBtnSaveAndPrint.Location = new System.Drawing.Point(249, 550);
            this.cBtnSaveAndPrint.Name = "cBtnSaveAndPrint";
            this.cBtnSaveAndPrint.Size = new System.Drawing.Size(209, 51);
            this.cBtnSaveAndPrint.TabIndex = 21;
            this.cBtnSaveAndPrint.Text = "Confirm";
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
            this.cBtnRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnRemoveBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnRemoveBook.Image = ((System.Drawing.Image)(resources.GetObject("cBtnRemoveBook.Image")));
            this.cBtnRemoveBook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cBtnRemoveBook.Location = new System.Drawing.Point(590, 130);
            this.cBtnRemoveBook.Name = "cBtnRemoveBook";
            this.cBtnRemoveBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cBtnRemoveBook.Size = new System.Drawing.Size(191, 41);
            this.cBtnRemoveBook.TabIndex = 20;
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
            this.cBtnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("cBtnAddBook.Image")));
            this.cBtnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnAddBook.Location = new System.Drawing.Point(369, 130);
            this.cBtnAddBook.Name = "cBtnAddBook";
            this.cBtnAddBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cBtnAddBook.Size = new System.Drawing.Size(191, 41);
            this.cBtnAddBook.TabIndex = 19;
            this.cBtnAddBook.Text = "Add Book";
            this.cBtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnAddBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBtnAddBook.UseVisualStyleBackColor = false;
            this.cBtnAddBook.Click += new System.EventHandler(this.cBtnAddBook_Click);
            // 
            // FormEntryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1061, 649);
            this.Controls.Add(this.cBtnCancel);
            this.Controls.Add(this.cBtnSaveAndPrint);
            this.Controls.Add(this.cBtnRemoveBook);
            this.Controls.Add(this.cBtnAddBook);
            this.Controls.Add(this.lbListOfBook);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEntryBook";
            this.Text = "FormEntryBook";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton cBtnSaveAndPrint;
        private CustomButton cBtnRemoveBook;
        private CustomButton cBtnAddBook;
        private System.Windows.Forms.Label lbListOfBook;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private CustomButton cBtnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
    }
}