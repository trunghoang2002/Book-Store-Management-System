namespace QLNS.Views.ViewWarehouse
{
    partial class FormWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarehouse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel2 = new QLNS.CustomPanel();
            this.lbTotalBRemaining = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.customPanel1 = new QLNS.CustomPanel();
            this.lbTotalBPurchared = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.rbCategory);
            this.groupBox1.Controls.Add(this.rbBook);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(60, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1109, 83);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // rbCategory
            // 
            this.rbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbCategory.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCategory.Image = ((System.Drawing.Image)(resources.GetObject("rbCategory.Image")));
            this.rbCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbCategory.Location = new System.Drawing.Point(685, 25);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(186, 39);
            this.rbCategory.TabIndex = 1;
            this.rbCategory.TabStop = true;
            this.rbCategory.Text = "Category";
            this.rbCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbCategory.UseVisualStyleBackColor = true;
            this.rbCategory.CheckedChanged += new System.EventHandler(this.rbCategory_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbBook.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBook.Image = ((System.Drawing.Image)(resources.GetObject("rbBook.Image")));
            this.rbBook.Location = new System.Drawing.Point(347, 25);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(139, 39);
            this.rbBook.TabIndex = 0;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
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
            this.BookID,
            this.BookName,
            this.TotalAmount,
            this.RemainingAmount,
            this.SoldAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(60, 270);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(1109, 328);
            this.dataGridViewBookOrder.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 16);
            this.panel1.TabIndex = 31;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 5;
            this.customPanel2.Controls.Add(this.lbTotalBRemaining);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.iconPictureBox2);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 30F;
            this.customPanel2.GradientBottonColor = System.Drawing.Color.IndianRed;
            this.customPanel2.GradientTopColor = System.Drawing.Color.IndianRed;
            this.customPanel2.Location = new System.Drawing.Point(745, 29);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(300, 140);
            this.customPanel2.TabIndex = 34;
            // 
            // lbTotalBRemaining
            // 
            this.lbTotalBRemaining.AutoSize = true;
            this.lbTotalBRemaining.BackColor = System.Drawing.Color.IndianRed;
            this.lbTotalBRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBRemaining.ForeColor = System.Drawing.Color.White;
            this.lbTotalBRemaining.Location = new System.Drawing.Point(138, 70);
            this.lbTotalBRemaining.Name = "lbTotalBRemaining";
            this.lbTotalBRemaining.Size = new System.Drawing.Size(26, 29);
            this.lbTotalBRemaining.TabIndex = 3;
            this.lbTotalBRemaining.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total book remaining";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.IndianRed;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.iconPictureBox2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 14);
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
            this.customPanel1.Controls.Add(this.lbTotalBPurchared);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.iconPictureBox1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 30F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.customPanel1.Location = new System.Drawing.Point(246, 29);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(300, 140);
            this.customPanel1.TabIndex = 33;
            // 
            // lbTotalBPurchared
            // 
            this.lbTotalBPurchared.AutoSize = true;
            this.lbTotalBPurchared.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.lbTotalBPurchared.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBPurchared.ForeColor = System.Drawing.Color.White;
            this.lbTotalBPurchared.Location = new System.Drawing.Point(132, 70);
            this.lbTotalBPurchared.Name = "lbTotalBPurchared";
            this.lbTotalBPurchared.Size = new System.Drawing.Size(26, 29);
            this.lbTotalBPurchared.TabIndex = 2;
            this.lbTotalBPurchared.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total book purchased";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(2, 13);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
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
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // RemainingAmount
            // 
            this.RemainingAmount.HeaderText = "Remaining Amount";
            this.RemainingAmount.MinimumWidth = 6;
            this.RemainingAmount.Name = "RemainingAmount";
            this.RemainingAmount.ReadOnly = true;
            // 
            // SoldAmount
            // 
            this.SoldAmount.HeaderText = "Sold amount";
            this.SoldAmount.MinimumWidth = 6;
            this.SoldAmount.Name = "SoldAmount";
            this.SoldAmount.ReadOnly = true;
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormWarehouse";
            this.Text = "FormManagementOrder";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.RadioButton rbBook;
        private CustomPanel customPanel2;
        private System.Windows.Forms.Label lbTotalBRemaining;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label lbTotalBPurchared;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldAmount;
    }
}