namespace QLNS.Views.ViewUser
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cBtnCancel = new QLNS.CustomButton();
            this.cBtnOK = new QLNS.CustomButton();
            this.cTextRepass = new QLNS.CustomTextBox();
            this.cTextNewPass = new QLNS.CustomTextBox();
            this.cTextCurentPass = new QLNS.CustomTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(647, 30);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(234, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(208, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "New password";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(242, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Comfirm password";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(312, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Passwords do not match";
            this.label8.Visible = false;
            // 
            // cBtnCancel
            // 
            this.cBtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cBtnCancel.Location = new System.Drawing.Point(360, 393);
            this.cBtnCancel.Name = "cBtnCancel";
            this.cBtnCancel.Size = new System.Drawing.Size(118, 40);
            this.cBtnCancel.TabIndex = 15;
            this.cBtnCancel.Text = "Cancel";
            this.cBtnCancel.TextColor = System.Drawing.Color.White;
            this.cBtnCancel.UseVisualStyleBackColor = false;
            this.cBtnCancel.Click += new System.EventHandler(this.cBtnCancel_Click);
            // 
            // cBtnOK
            // 
            this.cBtnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cBtnOK.BorderRadius = 5;
            this.cBtnOK.BorderSize = 0;
            this.cBtnOK.Enabled = false;
            this.cBtnOK.FlatAppearance.BorderSize = 0;
            this.cBtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnOK.ForeColor = System.Drawing.Color.White;
            this.cBtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnOK.Location = new System.Drawing.Point(189, 393);
            this.cBtnOK.Name = "cBtnOK";
            this.cBtnOK.Size = new System.Drawing.Size(118, 40);
            this.cBtnOK.TabIndex = 14;
            this.cBtnOK.Text = "Ok";
            this.cBtnOK.TextColor = System.Drawing.Color.White;
            this.cBtnOK.UseVisualStyleBackColor = false;
            this.cBtnOK.Click += new System.EventHandler(this.cBtnOK_Click);
            // 
            // cTextRepass
            // 
            this.cTextRepass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cTextRepass.BackColor = System.Drawing.SystemColors.Window;
            this.cTextRepass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cTextRepass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextRepass.BorderRadius = 4;
            this.cTextRepass.BorderSize = 2;
            this.cTextRepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextRepass.ForeColor = System.Drawing.Color.DimGray;
            this.cTextRepass.Location = new System.Drawing.Point(294, 274);
            this.cTextRepass.Margin = new System.Windows.Forms.Padding(4);
            this.cTextRepass.Multiline = false;
            this.cTextRepass.Name = "cTextRepass";
            this.cTextRepass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextRepass.PasswordChar = true;
            this.cTextRepass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextRepass.PlaceholderText = "";
            this.cTextRepass.Size = new System.Drawing.Size(259, 40);
            this.cTextRepass.TabIndex = 11;
            this.cTextRepass.Texts = "";
            this.cTextRepass.UnderlinedStyle = false;
            this.cTextRepass._TextChanged += new System.EventHandler(this.cTextRepass__TextChanged);
            // 
            // cTextNewPass
            // 
            this.cTextNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cTextNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.cTextNewPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cTextNewPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextNewPass.BorderRadius = 4;
            this.cTextNewPass.BorderSize = 2;
            this.cTextNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextNewPass.ForeColor = System.Drawing.Color.DimGray;
            this.cTextNewPass.Location = new System.Drawing.Point(294, 212);
            this.cTextNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.cTextNewPass.Multiline = false;
            this.cTextNewPass.Name = "cTextNewPass";
            this.cTextNewPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextNewPass.PasswordChar = true;
            this.cTextNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextNewPass.PlaceholderText = "";
            this.cTextNewPass.Size = new System.Drawing.Size(259, 40);
            this.cTextNewPass.TabIndex = 8;
            this.cTextNewPass.Texts = "";
            this.cTextNewPass.UnderlinedStyle = false;
            this.cTextNewPass._TextChanged += new System.EventHandler(this.cTextNewPass__TextChanged);
            // 
            // cTextCurentPass
            // 
            this.cTextCurentPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cTextCurentPass.BackColor = System.Drawing.SystemColors.Window;
            this.cTextCurentPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cTextCurentPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cTextCurentPass.BorderRadius = 4;
            this.cTextCurentPass.BorderSize = 2;
            this.cTextCurentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextCurentPass.ForeColor = System.Drawing.Color.DimGray;
            this.cTextCurentPass.Location = new System.Drawing.Point(294, 148);
            this.cTextCurentPass.Margin = new System.Windows.Forms.Padding(4);
            this.cTextCurentPass.Multiline = false;
            this.cTextCurentPass.Name = "cTextCurentPass";
            this.cTextCurentPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextCurentPass.PasswordChar = true;
            this.cTextCurentPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextCurentPass.PlaceholderText = "";
            this.cTextCurentPass.Size = new System.Drawing.Size(259, 40);
            this.cTextCurentPass.TabIndex = 5;
            this.cTextCurentPass.Texts = "";
            this.cTextCurentPass.UnderlinedStyle = false;
            this.cTextCurentPass._TextChanged += new System.EventHandler(this.cTextCurentPass__TextChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 473);
            this.Controls.Add(this.cBtnCancel);
            this.Controls.Add(this.cBtnOK);
            this.Controls.Add(this.cTextRepass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cTextNewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cTextCurentPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomTextBox cTextCurentPass;
        private CustomTextBox cTextNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomTextBox cTextRepass;
        private CustomButton cBtnCancel;
        private CustomButton cBtnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
    }
}