namespace QLNS.Views.ViewUserAccount
{
    partial class FormUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cTextBoxSearch = new QLNS.CustomTextBox();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.pictureBoxRole = new System.Windows.Forms.PictureBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.iBtnSort = new FontAwesome.Sharp.IconButton();
            this.iBtnResetPass = new FontAwesome.Sharp.IconButton();
            this.iBtnDeleteUserAccount = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            this.dataGridViewListOfStaff = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRole)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 42);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.cTextBoxSearch);
            this.panel1.Controls.Add(this.iBtnSearch);
            this.panel1.Controls.Add(this.pictureBoxRole);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(54, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 88);
            this.panel1.TabIndex = 25;
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
            this.cTextBoxSearch.Location = new System.Drawing.Point(608, 20);
            this.cTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxSearch.Multiline = false;
            this.cTextBoxSearch.Name = "cTextBoxSearch";
            this.cTextBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxSearch.PasswordChar = false;
            this.cTextBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxSearch.PlaceholderText = "";
            this.cTextBoxSearch.Size = new System.Drawing.Size(300, 47);
            this.cTextBoxSearch.TabIndex = 29;
            this.cTextBoxSearch.Texts = "";
            this.cTextBoxSearch.UnderlinedStyle = false;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.IconSize = 30;
            this.iBtnSearch.Location = new System.Drawing.Point(915, 20);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(65, 47);
            this.iBtnSearch.TabIndex = 28;
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // pictureBoxRole
            // 
            this.pictureBoxRole.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRole.Image")));
            this.pictureBoxRole.Location = new System.Drawing.Point(28, 25);
            this.pictureBoxRole.Name = "pictureBoxRole";
            this.pictureBoxRole.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxRole.TabIndex = 27;
            this.pictureBoxRole.TabStop = false;
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.White;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(144, 25);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(214, 39);
            this.cbRole.TabIndex = 25;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // lbRole
            // 
            this.lbRole.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(54, 2);
            this.lbRole.Margin = new System.Windows.Forms.Padding(0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(87, 82);
            this.lbRole.TabIndex = 26;
            this.lbRole.Text = "Role";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.cbSort);
            this.panel3.Controls.Add(this.iBtnSort);
            this.panel3.Controls.Add(this.iBtnResetPass);
            this.panel3.Controls.Add(this.iBtnDeleteUserAccount);
            this.panel3.Controls.Add(this.iBtnAdd);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(54, 674);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 88);
            this.panel3.TabIndex = 27;
            // 
            // cbSort
            // 
            this.cbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(734, 24);
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
            this.iBtnSort.Location = new System.Drawing.Point(628, 3);
            this.iBtnSort.Name = "iBtnSort";
            this.iBtnSort.Size = new System.Drawing.Size(100, 83);
            this.iBtnSort.TabIndex = 20;
            this.iBtnSort.Text = "Sort";
            this.iBtnSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnSort.UseVisualStyleBackColor = true;
            this.iBtnSort.Click += new System.EventHandler(this.iBtnSort_Click);
            // 
            // iBtnResetPass
            // 
            this.iBtnResetPass.FlatAppearance.BorderSize = 0;
            this.iBtnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnResetPass.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iBtnResetPass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnResetPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnResetPass.IconSize = 30;
            this.iBtnResetPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnResetPass.Location = new System.Drawing.Point(352, 3);
            this.iBtnResetPass.Name = "iBtnResetPass";
            this.iBtnResetPass.Size = new System.Drawing.Size(270, 83);
            this.iBtnResetPass.TabIndex = 19;
            this.iBtnResetPass.Text = "Reset Password";
            this.iBtnResetPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnResetPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnResetPass.UseVisualStyleBackColor = true;
            this.iBtnResetPass.Click += new System.EventHandler(this.iBtnResetPass_Click);
            // 
            // iBtnDeleteUserAccount
            // 
            this.iBtnDeleteUserAccount.FlatAppearance.BorderSize = 0;
            this.iBtnDeleteUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDeleteUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDeleteUserAccount.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iBtnDeleteUserAccount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDeleteUserAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteUserAccount.IconSize = 30;
            this.iBtnDeleteUserAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDeleteUserAccount.Location = new System.Drawing.Point(202, 3);
            this.iBtnDeleteUserAccount.Name = "iBtnDeleteUserAccount";
            this.iBtnDeleteUserAccount.Size = new System.Drawing.Size(144, 83);
            this.iBtnDeleteUserAccount.TabIndex = 18;
            this.iBtnDeleteUserAccount.Text = "Delete";
            this.iBtnDeleteUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDeleteUserAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDeleteUserAccount.UseVisualStyleBackColor = true;
            this.iBtnDeleteUserAccount.Click += new System.EventHandler(this.iBtnDeleteUserAccount_Click);
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
            // dataGridViewListOfStaff
            // 
            this.dataGridViewListOfStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListOfStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListOfStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewListOfStaff.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListOfStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListOfStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewListOfStaff.ColumnHeadersHeight = 70;
            this.dataGridViewListOfStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName,
            this.Gender,
            this.DateOfBirth,
            this.PhonNumber,
            this.Email,
            this.Address,
            this.Role});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOfStaff.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewListOfStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewListOfStaff.Location = new System.Drawing.Point(54, 140);
            this.dataGridViewListOfStaff.Name = "dataGridViewListOfStaff";
            this.dataGridViewListOfStaff.ReadOnly = true;
            this.dataGridViewListOfStaff.RowHeadersVisible = false;
            this.dataGridViewListOfStaff.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewListOfStaff.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewListOfStaff.RowTemplate.Height = 24;
            this.dataGridViewListOfStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListOfStaff.Size = new System.Drawing.Size(997, 531);
            this.dataGridViewListOfStaff.TabIndex = 28;
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
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date of birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // PhonNumber
            // 
            this.PhonNumber.HeaderText = "Phone number";
            this.PhonNumber.MinimumWidth = 6;
            this.PhonNumber.Name = "PhonNumber";
            this.PhonNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // FormUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 845);
            this.Controls.Add(this.dataGridViewListOfStaff);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormUserAccount";
            this.Text = "FormUserAccount";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRole)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox cTextBoxSearch;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.PictureBox pictureBoxRole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbSort;
        private FontAwesome.Sharp.IconButton iBtnSort;
        private FontAwesome.Sharp.IconButton iBtnDeleteUserAccount;
        private FontAwesome.Sharp.IconButton iBtnAdd;
        private System.Windows.Forms.DataGridView dataGridViewListOfStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhonNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private FontAwesome.Sharp.IconButton iBtnResetPass;
    }
}