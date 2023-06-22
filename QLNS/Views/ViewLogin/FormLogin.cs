using QLNS.BLL;
using QLNS.DTO;
using QLNS.Views.ViewDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Views.ViewLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            ipHide.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBtnLogin_Click(object sender, EventArgs e)
        {
            if (cTextBoxUsername.Texts == cTextBoxUsername.PlaceholderText)
            {
                MessageBox.Show("Please enter Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cTextBoxUsername.Focus();
                cTextBoxUsername.BorderColor = Color.Red;
                cTextBoxUsername.BorderFocusColor = Color.Red;
                return;
            }
            if (cTextBoxPassword.Texts == "")
            {
                MessageBox.Show("Please enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cTextBoxPassword.Focus();
                cTextBoxPassword.BorderColor = Color.Red;
                cTextBoxPassword.BorderFocusColor = Color.Red;
                return;
            }
            if (BLL_Login.Instance.CheckLogin(cTextBoxUsername.Texts, cTextBoxPassword.Texts))
            {
                User_Role role = BLL_Login.Instance.GetRole();
                this.Hide();
                if (role.ID_Role == 1)
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.ShowDialog();
                }
                else if (role.ID_Role == 2)
                {
                    FormSalePerson formSale = new FormSalePerson();
                    formSale.ShowDialog();
                }
                else if (role.ID_Role == 3)
                {
                    FormStocker formStocker = new FormStocker();
                    formStocker.ShowDialog();
                }
                Application.Restart(); // có thể tạo thêm 1 bảng để lưu username lần cuối đăng nhập
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxUsername.BorderColor = Color.Red;
                cTextBoxUsername.BorderFocusColor = Color.Red;
                cTextBoxPassword.BorderColor = Color.Red;
                cTextBoxPassword.BorderFocusColor = Color.Red;
            }
        }

        private void cTextBoxUsername__TextChanged(object sender, EventArgs e)
        {
            cTextBoxUsername.BorderColor = Color.FromArgb(238, 238, 238);
            cTextBoxUsername.BorderFocusColor = Color.FromArgb(92, 102, 244);
        }

        private void cTextBoxPassword__TextChanged(object sender, EventArgs e)
        {
            cTextBoxPassword.BorderColor = Color.FromArgb(238, 238, 238);
            cTextBoxPassword.BorderFocusColor = Color.FromArgb(92, 102, 244);
        }

        private void ipEye_Click(object sender, EventArgs e)
        {
            if (cTextBoxPassword.PasswordChar == false)
            {
                ipHide.BringToFront();
                cTextBoxPassword.PasswordChar = true;
            }
        }

        private void ipHide_Click(object sender, EventArgs e)
        {
            if (cTextBoxPassword.PasswordChar == true)
            {
                ipEye.BringToFront();
                cTextBoxPassword.PasswordChar = false;
            }
        }
    }
}
