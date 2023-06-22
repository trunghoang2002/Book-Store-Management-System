namespace QLNS.Views.ViewManagerBill
{
    partial class FormManagementBill
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
            this.panelMOrder = new System.Windows.Forms.Panel();
            this.cTextCustomerName = new QLNS.CustomTextBox();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iBtnDetail = new FontAwesome.Sharp.IconButton();
            this.dataGridViewBookOrder = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 42);
            this.panel1.TabIndex = 4;
            // 
            // panelMOrder
            // 
            this.panelMOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelMOrder.Controls.Add(this.cTextCustomerName);
            this.panelMOrder.Controls.Add(this.iBtnSearch);
            this.panelMOrder.Controls.Add(this.iBtnDelete);
            this.panelMOrder.Controls.Add(this.iBtnDetail);
            this.panelMOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMOrder.Location = new System.Drawing.Point(60, 47);
            this.panelMOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMOrder.Name = "panelMOrder";
            this.panelMOrder.Size = new System.Drawing.Size(997, 88);
            this.panelMOrder.TabIndex = 11;
            // 
            // cTextCustomerName
            // 
            this.cTextCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextCustomerName.BackColor = System.Drawing.Color.White;
            this.cTextCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextCustomerName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextCustomerName.BorderRadius = 4;
            this.cTextCustomerName.BorderSize = 2;
            this.cTextCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextCustomerName.ForeColor = System.Drawing.Color.Black;
            this.cTextCustomerName.Location = new System.Drawing.Point(565, 22);
            this.cTextCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.cTextCustomerName.Multiline = false;
            this.cTextCustomerName.Name = "cTextCustomerName";
            this.cTextCustomerName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextCustomerName.PasswordChar = false;
            this.cTextCustomerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextCustomerName.PlaceholderText = "";
            this.cTextCustomerName.Size = new System.Drawing.Size(347, 47);
            this.cTextCustomerName.TabIndex = 21;
            this.cTextCustomerName.Texts = "";
            this.cTextCustomerName.UnderlinedStyle = false;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.IconSize = 30;
            this.iBtnSearch.Location = new System.Drawing.Point(919, 23);
            this.iBtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(65, 47);
            this.iBtnSearch.TabIndex = 20;
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
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
            this.iBtnDelete.Location = new System.Drawing.Point(179, 4);
            this.iBtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(144, 82);
            this.iBtnDelete.TabIndex = 18;
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
            this.iBtnDetail.Location = new System.Drawing.Point(32, 3);
            this.iBtnDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iBtnDetail.Name = "iBtnDetail";
            this.iBtnDetail.Size = new System.Drawing.Size(144, 84);
            this.iBtnDetail.TabIndex = 17;
            this.iBtnDetail.Text = "Detail";
            this.iBtnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDetail.UseVisualStyleBackColor = true;
            this.iBtnDetail.Click += new System.EventHandler(this.iBtnDetail_Click);
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
            this.StaffID,
            this.NameCustomer,
            this.Date,
            this.PaymentMethod,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewBookOrder.Location = new System.Drawing.Point(60, 140);
            this.dataGridViewBookOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBookOrder.Name = "dataGridViewBookOrder";
            this.dataGridViewBookOrder.ReadOnly = true;
            this.dataGridViewBookOrder.RowHeadersVisible = false;
            this.dataGridViewBookOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookOrder.RowTemplate.Height = 24;
            this.dataGridViewBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookOrder.Size = new System.Drawing.Size(997, 461);
            this.dataGridViewBookOrder.TabIndex = 15;
            // 
            // BillID
            // 
            this.BillID.HeaderText = "Bill\'s ID";
            this.BillID.MinimumWidth = 6;
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "Staff\'s ID";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // NameCustomer
            // 
            this.NameCustomer.HeaderText = "Name Customer";
            this.NameCustomer.MinimumWidth = 6;
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total(VND)";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FormManagementBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 612);
            this.Controls.Add(this.dataGridViewBookOrder);
            this.Controls.Add(this.panelMOrder);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormManagementBill";
            this.Text = "FormManagementOrder";
            this.panelMOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMOrder;
        private System.Windows.Forms.DataGridView dataGridViewBookOrder;
        private FontAwesome.Sharp.IconButton iBtnDetail;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private CustomTextBox cTextCustomerName;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}