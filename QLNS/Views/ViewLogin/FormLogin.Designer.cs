namespace QLNS.Views.ViewLogin
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel1 = new QLNS.CustomPanel();
            this.customPanel2 = new QLNS.CustomPanel();
            this.ipEye = new FontAwesome.Sharp.IconPictureBox();
            this.ipHide = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cBtnLogin = new QLNS.CustomButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cTextBoxPassword = new QLNS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cTextBoxUsername = new QLNS.CustomTextBox();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(622, 40);
            this.panelTitle.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 676);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 40);
            this.panel1.TabIndex = 2;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 17;
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.OldLace;
            this.customPanel1.GradientTopColor = System.Drawing.Color.BlanchedAlmond;
            this.customPanel1.Location = new System.Drawing.Point(35, 46);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(554, 624);
            this.customPanel1.TabIndex = 0;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.Controls.Add(this.ipEye);
            this.customPanel2.Controls.Add(this.ipHide);
            this.customPanel2.Controls.Add(this.btnClose);
            this.customPanel2.Controls.Add(this.pictureBox3);
            this.customPanel2.Controls.Add(this.cBtnLogin);
            this.customPanel2.Controls.Add(this.pictureBox2);
            this.customPanel2.Controls.Add(this.cTextBoxPassword);
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.Controls.Add(this.lbUserName);
            this.customPanel2.Controls.Add(this.pictureBox1);
            this.customPanel2.Controls.Add(this.cTextBoxUsername);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottonColor = System.Drawing.Color.White;
            this.customPanel2.GradientTopColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(40, 27);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(476, 559);
            this.customPanel2.TabIndex = 0;
            // 
            // ipEye
            // 
            this.ipEye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipEye.BackColor = System.Drawing.SystemColors.Window;
            this.ipEye.ForeColor = System.Drawing.Color.Black;
            this.ipEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ipEye.IconColor = System.Drawing.Color.Black;
            this.ipEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipEye.Location = new System.Drawing.Point(360, 365);
            this.ipEye.Name = "ipEye";
            this.ipEye.Size = new System.Drawing.Size(32, 32);
            this.ipEye.TabIndex = 12;
            this.ipEye.TabStop = false;
            this.ipEye.Click += new System.EventHandler(this.ipEye_Click);
            // 
            // ipHide
            // 
            this.ipHide.BackColor = System.Drawing.Color.White;
            this.ipHide.ForeColor = System.Drawing.Color.Black;
            this.ipHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.ipHide.IconColor = System.Drawing.Color.Black;
            this.ipHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipHide.Location = new System.Drawing.Point(360, 365);
            this.ipHide.Name = "ipHide";
            this.ipHide.Size = new System.Drawing.Size(32, 32);
            this.ipHide.TabIndex = 11;
            this.ipHide.TabStop = false;
            this.ipHide.Click += new System.EventHandler(this.ipHide_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(403, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 59);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::QLNS.Properties.Resources._3532091;
            this.pictureBox3.Location = new System.Drawing.Point(160, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // cBtnLogin
            // 
            this.cBtnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBtnLogin.BackColor = System.Drawing.Color.PeachPuff;
            this.cBtnLogin.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.cBtnLogin.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.cBtnLogin.BorderRadius = 20;
            this.cBtnLogin.BorderSize = 0;
            this.cBtnLogin.FlatAppearance.BorderSize = 0;
            this.cBtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnLogin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnLogin.Location = new System.Drawing.Point(76, 462);
            this.cBtnLogin.Name = "cBtnLogin";
            this.cBtnLogin.Size = new System.Drawing.Size(325, 68);
            this.cBtnLogin.TabIndex = 6;
            this.cBtnLogin.Text = "Login";
            this.cBtnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBtnLogin.UseVisualStyleBackColor = false;
            this.cBtnLogin.Click += new System.EventHandler(this.cBtnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // cTextBoxPassword
            // 
            this.cTextBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxPassword.BorderFocusColor = System.Drawing.Color.BlanchedAlmond;
            this.cTextBoxPassword.BorderRadius = 5;
            this.cTextBoxPassword.BorderSize = 2;
            this.cTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cTextBoxPassword.Location = new System.Drawing.Point(131, 357);
            this.cTextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBoxPassword.Multiline = false;
            this.cTextBoxPassword.Name = "cTextBoxPassword";
            this.cTextBoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxPassword.PasswordChar = true;
            this.cTextBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxPassword.PlaceholderText = "";
            this.cTextBoxPassword.Size = new System.Drawing.Size(266, 44);
            this.cTextBoxPassword.TabIndex = 4;
            this.cTextBoxPassword.Texts = "";
            this.cTextBoxPassword.UnderlinedStyle = false;
            this.cTextBoxPassword._TextChanged += new System.EventHandler(this.cTextBoxPassword__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(57, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUserName.Location = new System.Drawing.Point(57, 210);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(107, 28);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cTextBoxUsername
            // 
            this.cTextBoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBoxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBoxUsername.BorderFocusColor = System.Drawing.Color.BlanchedAlmond;
            this.cTextBoxUsername.BorderRadius = 5;
            this.cTextBoxUsername.BorderSize = 2;
            this.cTextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cTextBoxUsername.Location = new System.Drawing.Point(131, 249);
            this.cTextBoxUsername.Margin = new System.Windows.Forms.Padding(0);
            this.cTextBoxUsername.Multiline = false;
            this.cTextBoxUsername.Name = "cTextBoxUsername";
            this.cTextBoxUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBoxUsername.PasswordChar = false;
            this.cTextBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextBoxUsername.PlaceholderText = "";
            this.cTextBoxUsername.Size = new System.Drawing.Size(266, 44);
            this.cTextBoxUsername.TabIndex = 0;
            this.cTextBoxUsername.Texts = "";
            this.cTextBoxUsername.UnderlinedStyle = false;
            this.cTextBoxUsername._TextChanged += new System.EventHandler(this.cTextBoxUsername__TextChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.customPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private CustomPanel customPanel2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomTextBox cTextBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomTextBox cTextBoxPassword;
        private CustomButton cBtnLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private FontAwesome.Sharp.IconPictureBox ipHide;
        private FontAwesome.Sharp.IconPictureBox ipEye;
    }
}