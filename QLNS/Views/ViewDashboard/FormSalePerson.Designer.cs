namespace QLNS.Views.ViewDashboard
{
    partial class FormSalePerson
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
            this.components = new System.ComponentModel.Container();
            FontAwesome.Sharp.IconButton iBtnMinimize;
            FontAwesome.Sharp.IconButton ibtnRevenue;
            FontAwesome.Sharp.IconButton ibtnManageBill;
            FontAwesome.Sharp.IconButton ibtnBill;
            FontAwesome.Sharp.IconButton ibtnUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalePerson));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iBtnSlidingMenu = new FontAwesome.Sharp.IconButton();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.iBtnExit = new FontAwesome.Sharp.IconButton();
            this.iBtnMaximize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.title2panel = new System.Windows.Forms.Panel();
            this.iPicClock = new FontAwesome.Sharp.IconPictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.lbNameRole = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            iBtnMinimize = new FontAwesome.Sharp.IconButton();
            ibtnRevenue = new FontAwesome.Sharp.IconButton();
            ibtnManageBill = new FontAwesome.Sharp.IconButton();
            ibtnBill = new FontAwesome.Sharp.IconButton();
            ibtnUser = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.title2panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPicClock)).BeginInit();
            this.SuspendLayout();
            // 
            // iBtnMinimize
            // 
            iBtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iBtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            iBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iBtnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            iBtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iBtnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            iBtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnMinimize.IconSize = 20;
            iBtnMinimize.Location = new System.Drawing.Point(848, 1);
            iBtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            iBtnMinimize.Name = "iBtnMinimize";
            iBtnMinimize.Size = new System.Drawing.Size(50, 44);
            iBtnMinimize.TabIndex = 9;
            iBtnMinimize.UseVisualStyleBackColor = false;
            iBtnMinimize.Click += new System.EventHandler(this.iBtnMinimize_Click);
            // 
            // ibtnRevenue
            // 
            ibtnRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            ibtnRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            ibtnRevenue.FlatAppearance.BorderSize = 0;
            ibtnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ibtnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnRevenue.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            ibtnRevenue.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnRevenue.IconSize = 35;
            ibtnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnRevenue.Location = new System.Drawing.Point(0, 385);
            ibtnRevenue.Margin = new System.Windows.Forms.Padding(16, 0, 30, 0);
            ibtnRevenue.Name = "ibtnRevenue";
            ibtnRevenue.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            ibtnRevenue.Size = new System.Drawing.Size(257, 70);
            ibtnRevenue.TabIndex = 12;
            ibtnRevenue.Tag = "Revenue";
            ibtnRevenue.Text = "Revenue";
            ibtnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnRevenue.UseVisualStyleBackColor = false;
            ibtnRevenue.Click += new System.EventHandler(this.ibtnRevenue_Click);
            // 
            // ibtnManageBill
            // 
            ibtnManageBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            ibtnManageBill.Dock = System.Windows.Forms.DockStyle.Top;
            ibtnManageBill.FlatAppearance.BorderSize = 0;
            ibtnManageBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ibtnManageBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnManageBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnManageBill.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            ibtnManageBill.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnManageBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnManageBill.IconSize = 35;
            ibtnManageBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnManageBill.Location = new System.Drawing.Point(0, 315);
            ibtnManageBill.Margin = new System.Windows.Forms.Padding(16, 0, 30, 0);
            ibtnManageBill.Name = "ibtnManageBill";
            ibtnManageBill.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            ibtnManageBill.Size = new System.Drawing.Size(257, 70);
            ibtnManageBill.TabIndex = 11;
            ibtnManageBill.Tag = "Management Bill";
            ibtnManageBill.Text = "Management Bill";
            ibtnManageBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnManageBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnManageBill.UseVisualStyleBackColor = false;
            ibtnManageBill.Click += new System.EventHandler(this.ibtnManageO_Click);
            // 
            // ibtnBill
            // 
            ibtnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            ibtnBill.Dock = System.Windows.Forms.DockStyle.Top;
            ibtnBill.FlatAppearance.BorderSize = 0;
            ibtnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ibtnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnBill.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            ibtnBill.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBill.IconSize = 35;
            ibtnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnBill.Location = new System.Drawing.Point(0, 245);
            ibtnBill.Margin = new System.Windows.Forms.Padding(16, 0, 30, 0);
            ibtnBill.Name = "ibtnBill";
            ibtnBill.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            ibtnBill.Size = new System.Drawing.Size(257, 70);
            ibtnBill.TabIndex = 10;
            ibtnBill.Tag = "Bill";
            ibtnBill.Text = "Bill";
            ibtnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnBill.UseVisualStyleBackColor = false;
            ibtnBill.Click += new System.EventHandler(this.ibtnOder_Click);
            // 
            // ibtnUser
            // 
            ibtnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            ibtnUser.Dock = System.Windows.Forms.DockStyle.Top;
            ibtnUser.FlatAppearance.BorderSize = 0;
            ibtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ibtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            ibtnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnUser.IconSize = 35;
            ibtnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnUser.Location = new System.Drawing.Point(0, 175);
            ibtnUser.Margin = new System.Windows.Forms.Padding(0);
            ibtnUser.Name = "ibtnUser";
            ibtnUser.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            ibtnUser.Size = new System.Drawing.Size(257, 70);
            ibtnUser.TabIndex = 9;
            ibtnUser.Tag = "User";
            ibtnUser.Text = "User";
            ibtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnUser.UseVisualStyleBackColor = false;
            ibtnUser.Click += new System.EventHandler(this.ibtnUser_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelMenu.Controls.Add(ibtnRevenue);
            this.panelMenu.Controls.Add(ibtnManageBill);
            this.panelMenu.Controls.Add(ibtnBill);
            this.panelMenu.Controls.Add(ibtnUser);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(257, 596);
            this.panelMenu.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 20);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.iBtnSlidingMenu);
            this.panel1.Controls.Add(this.pictureHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 155);
            this.panel1.TabIndex = 4;
            // 
            // iBtnSlidingMenu
            // 
            this.iBtnSlidingMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.iBtnSlidingMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnSlidingMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.iBtnSlidingMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iBtnSlidingMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnSlidingMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSlidingMenu.IconSize = 30;
            this.iBtnSlidingMenu.Location = new System.Drawing.Point(171, 5);
            this.iBtnSlidingMenu.Margin = new System.Windows.Forms.Padding(0);
            this.iBtnSlidingMenu.Name = "iBtnSlidingMenu";
            this.iBtnSlidingMenu.Size = new System.Drawing.Size(60, 58);
            this.iBtnSlidingMenu.TabIndex = 6;
            this.iBtnSlidingMenu.UseVisualStyleBackColor = false;
            this.iBtnSlidingMenu.Click += new System.EventHandler(this.iBtnSlidingMenu_Click);
            // 
            // pictureHome
            // 
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(27, 15);
            this.pictureHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(141, 102);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 6;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.titlePanel.Controls.Add(this.iBtnExit);
            this.titlePanel.Controls.Add(this.iBtnMaximize);
            this.titlePanel.Controls.Add(iBtnMinimize);
            this.titlePanel.Controls.Add(this.lblTitleChildForm);
            this.titlePanel.Controls.Add(this.iconCurrentChildForm);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(257, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(999, 63);
            this.titlePanel.TabIndex = 5;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // iBtnExit
            // 
            this.iBtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.iBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.iBtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iBtnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnExit.IconSize = 20;
            this.iBtnExit.Location = new System.Drawing.Point(946, 2);
            this.iBtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.iBtnExit.Name = "iBtnExit";
            this.iBtnExit.Size = new System.Drawing.Size(50, 44);
            this.iBtnExit.TabIndex = 7;
            this.iBtnExit.UseVisualStyleBackColor = false;
            this.iBtnExit.Click += new System.EventHandler(this.iBtnExit_Click);
            // 
            // iBtnMaximize
            // 
            this.iBtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.iBtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.iBtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iBtnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnMaximize.IconSize = 20;
            this.iBtnMaximize.Location = new System.Drawing.Point(898, 2);
            this.iBtnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.iBtnMaximize.Name = "iBtnMaximize";
            this.iBtnMaximize.Size = new System.Drawing.Size(50, 44);
            this.iBtnMaximize.TabIndex = 8;
            this.iBtnMaximize.UseVisualStyleBackColor = false;
            this.iBtnMaximize.Click += new System.EventHandler(this.iBtnMaximize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(107, 21);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(355, 23);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(69, 15);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(257, 155);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(999, 441);
            this.panelDesktop.TabIndex = 6;
            // 
            // title2panel
            // 
            this.title2panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.title2panel.Controls.Add(this.iPicClock);
            this.title2panel.Controls.Add(this.labelTime);
            this.title2panel.Controls.Add(this.lbNameRole);
            this.title2panel.Controls.Add(this.lbRole);
            this.title2panel.Controls.Add(this.lbNameUser);
            this.title2panel.Controls.Add(this.lbWelcome);
            this.title2panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title2panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title2panel.Location = new System.Drawing.Point(257, 63);
            this.title2panel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.title2panel.Name = "title2panel";
            this.title2panel.Size = new System.Drawing.Size(999, 92);
            this.title2panel.TabIndex = 10;
            // 
            // iPicClock
            // 
            this.iPicClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iPicClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.iPicClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iPicClock.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iPicClock.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iPicClock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPicClock.Location = new System.Drawing.Point(822, 30);
            this.iPicClock.Name = "iPicClock";
            this.iPicClock.Size = new System.Drawing.Size(32, 32);
            this.iPicClock.TabIndex = 5;
            this.iPicClock.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTime.Location = new System.Drawing.Point(860, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(122, 25);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // lbNameRole
            // 
            this.lbNameRole.AutoSize = true;
            this.lbNameRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNameRole.Location = new System.Drawing.Point(451, 34);
            this.lbNameRole.Name = "lbNameRole";
            this.lbNameRole.Size = new System.Drawing.Size(64, 25);
            this.lbNameRole.TabIndex = 3;
            this.lbNameRole.Text = "Name";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbRole.Location = new System.Drawing.Point(395, 34);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(67, 25);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "Role : ";
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNameUser.Location = new System.Drawing.Point(170, 35);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(64, 25);
            this.lbNameUser.TabIndex = 1;
            this.lbNameUser.Text = "Name";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbWelcome.Location = new System.Drawing.Point(64, 34);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(111, 25);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome : ";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // FormSalePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 596);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.title2panel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormSalePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLNS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.title2panel.ResumeLayout(false);
            this.title2panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPicClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.PictureBox pictureHome;
        private FontAwesome.Sharp.IconButton iBtnSlidingMenu;
        private FontAwesome.Sharp.IconButton iBtnExit;
        private FontAwesome.Sharp.IconButton iBtnMaximize;
        private System.Windows.Forms.Panel title2panel;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerTime;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iPicClock;
        private System.Windows.Forms.Label lbNameRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

