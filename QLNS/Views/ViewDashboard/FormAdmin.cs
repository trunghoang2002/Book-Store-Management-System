using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QLNS.BLL;
using QLNS.Views.ViewBill;
using QLNS.Views.ViewBook;
using QLNS.Views.ViewDiscount;
using QLNS.Views.ViewEntryBook;
using QLNS.Views.ViewEntryDiary;
using QLNS.Views.ViewExpense;
using QLNS.Views.ViewManagerBill;
using QLNS.Views.ViewRevenueAdmin;
using QLNS.Views.ViewUser;
using QLNS.Views.ViewUserAccount;
using QLNS.Views.ViewWarehouse;

namespace QLNS.Views.ViewDashboard
{
    public partial class FormAdmin : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private int BorderSize = 2; // viền xanh
        private Color colorBtn = Color.FromArgb(98, 102, 244);

        private Form currentChildForm;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

        public FormAdmin()
        {
            InitializeComponent();
            timerTime.Start();
            GUIFORM();
            customizeDesing();
        }
        // submenu
        private void customizeDesing()
        {
            panelSubmenuSales.Visible = false;
            panelSubmenuStocker.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubmenuSales.Visible == true)
            {
                panelSubmenuSales.Visible = false;
            }
            if (panelSubmenuStocker.Visible == true)
            {
                panelSubmenuStocker.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private bool checkShowSub()
        {
            if (panelSubmenuSales.Visible == true)
            {
                return true;
            }
            else if (panelSubmenuSales.Visible == true)
            {
                return true;
            }
            return false;
        }
        // end submenu
        private void GUIFORM()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text = "QLSN";
            this.BackColor = Color.FromArgb(98, 102, 244);
            //this.DoubleBuffered = true;

            //label
            lbNameUser.Text = BLL_Login.Instance.GetStaff().NameStaff;
            lbNameRole.Text = BLL_Login.Instance.GetRole().NameRole;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(247, 247, 247);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //
                if (panelSubmenuStocker.Contains(currentBtn) == true)
                {
                    iBtnStocker.BackColor = Color.FromArgb(247, 247, 247);
                    iBtnStocker.ForeColor = color;
                    iBtnStocker.TextAlign = ContentAlignment.MiddleCenter;
                    iBtnStocker.IconColor = color;
                }
                else if (panelSubmenuSales.Contains(currentBtn) == true)
                {
                    iBtnSales.BackColor = Color.FromArgb(247, 247, 247);
                    iBtnSales.ForeColor = color;
                    iBtnSales.TextAlign = ContentAlignment.MiddleCenter;
                    iBtnSales.IconColor = color;
                }
                else
                {
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                }
                leftBorderBtn.BringToFront();
                //
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                if (currentBtn == ibtnBill || currentBtn == ibtnManageBill)
                {
                    iBtnSales.BackColor = Color.FromArgb(238, 238, 238);
                    iBtnSales.ForeColor = Color.FromArgb(64, 64, 64);
                    iBtnSales.IconColor = Color.FromArgb(64, 64, 64);
                }
                else if (currentBtn == ibtnBookEntry || currentBtn == ibtnBookEntryDiary)
                {
                    iBtnStocker.BackColor = Color.FromArgb(238, 238, 238);
                    iBtnStocker.ForeColor = Color.FromArgb(64, 64, 64);
                    iBtnStocker.IconColor = Color.FromArgb(64, 64, 64);
                }
                currentBtn.BackColor = Color.FromArgb(238, 238, 238);
                currentBtn.ForeColor = Color.FromArgb(64, 64, 64);
                currentBtn.IconColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void OpenChildFrom(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iBtnUser_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormUser());
        }

        private void iBtnBook_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormBook());

        }

        private void iBtnUserAccount_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormUserAccount());

        }

        private void iBtnDiscount_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormDiscount());


        }

        private void iBtnWarehouse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormWarehouse());

        }

        private void iBtnExpense_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormExpense());

        }

        private void iBtnRevenue_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormRevenueAdmin());
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            hideSubMenu();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            lblTitleChildForm.Text = "Home";
        }

        //
        #region DragForm & Remove title bar & keep snap window
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Remove title bar and keep snap window
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion
        // Resize form
        #region Resize 
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != BorderSize)
                    {
                        this.Padding = new Padding(BorderSize);
                    }
                    break;
            }

        }
        #endregion
        //
        #region Zoom max,Zoom min, Zoom nomar
        private void iBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iBtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        #endregion
        //
        #region Sliding Menu
        private void iBtnSlidingMenu_Click(object sender, EventArgs e)
        {
            Collapsemenu();
        }
        private void Collapsemenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureHome.Visible = false;
                iBtnSlidingMenu.Dock = DockStyle.Fill;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 260;
                pictureHome.Visible = true;
                iBtnSlidingMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        #endregion
        //
        private void iBtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        // Dong` ho`
        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("HH:mm:ss");
        }

        private void iBtnSales_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubmenuSales);
            ActivateButton(sender, colorBtn);
        }

        private void iBtnStocker_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubmenuStocker);
            ActivateButton(sender, colorBtn);
        }

        private void ibtnBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormBill());
        }

        private void ibtnManageBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormManagementBill());
        }

        private void ibtnBookEntry_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new FormEntryBook());
        }

        private void ibtnBookEntryDiary_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorBtn);
            OpenChildFrom(new EntryDiaryBook());
        }
    }
}
