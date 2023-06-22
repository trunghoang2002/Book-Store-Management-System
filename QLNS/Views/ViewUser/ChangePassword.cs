using QLNS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Views.ViewUser
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        //Shadow
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void HighlightNewPass()
        {
            cTextNewPass.Focus();
            cTextNewPass.BorderColor = Color.Red;
            cTextNewPass.BorderFocusColor = Color.Red;
        }

        private bool CheckPass()
        {
            string oldPass = cTextCurentPass.Texts;
            if (BLL_Login.Instance.EncodePass(oldPass) == BLL_Login.Instance.password) return true;
            else return false;
        }

        private bool CheckPasswordChar()
        {
            if (cTextNewPass.Texts.Length < 6)
            {
                MessageBox.Show("The password must be at least 6 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HighlightNewPass();
                return false;
            }
            if (cTextNewPass.Texts.Length > 20)
            {
                MessageBox.Show("The password must be less than 20 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HighlightNewPass();
                return false;
            }
            if (cTextNewPass.Texts.Any(char.IsDigit) == false)
            {
                MessageBox.Show("The password must contain at least one digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HighlightNewPass();
                return false;
            }
            if (cTextNewPass.Texts.Any(char.IsUpper) == false)
            {
                MessageBox.Show("The password must contain at least one uppercase letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HighlightNewPass();
                return false;
            }
            if (cTextNewPass.Texts.Any(char.IsLower) == false)
            {
                MessageBox.Show("The password must contain at least one lowercase letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HighlightNewPass();
                return false;
            }
            return true;
        }

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBtnOK_Click(object sender, EventArgs e)
        {
            if (cTextCurentPass.Texts == "")
            {
                MessageBox.Show("The current password cannot be left blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cTextCurentPass.Focus();
                cTextCurentPass.BorderColor = Color.Red;
                cTextCurentPass.BorderFocusColor = Color.Red;
                return;
            }
            string newPass = cTextNewPass.Texts;
            if (CheckPass())
            {
                if (!CheckPasswordChar()) return;
                BLL_Login.Instance.ChangePass(newPass);
                cTextCurentPass.BorderColor = Color.Green;
                MessageBox.Show("Done!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("The current password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextCurentPass.Focus();
                cTextCurentPass.BorderColor = Color.Red;
                cTextCurentPass.BorderFocusColor = Color.Red;
            }
        }

        private void cTextRepass__TextChanged(object sender, EventArgs e)
        {  
            if (cTextRepass.Texts == cTextNewPass.Texts)
            {
                cBtnOK.Enabled = true;
                cTextNewPass.BorderColor = Color.Green;
                cTextNewPass.BorderFocusColor = Color.Green;
                cTextRepass.BorderColor = Color.Green;
                cTextRepass.BorderFocusColor = Color.Green;
                label8.Visible = false;
            } 
            else
            {
                cBtnOK.Enabled = false;
                cTextNewPass.BorderColor = Color.Red;
                cTextNewPass.BorderFocusColor = Color.Red;
                cTextRepass.BorderColor = Color.Red;
                cTextRepass.BorderFocusColor = Color.Red;
                label8.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cTextCurentPass__TextChanged(object sender, EventArgs e)
        {
            cTextCurentPass.BorderColor = Color.FromArgb(238, 238, 238);
            cTextCurentPass.BorderFocusColor = Color.FromArgb(92, 102, 244);
        }

        private void cTextNewPass__TextChanged(object sender, EventArgs e)
        {
            if (cTextRepass.Texts == cTextNewPass.Texts)
            {
                cBtnOK.Enabled = true;
                cTextNewPass.BorderColor = Color.Green;
                cTextNewPass.BorderFocusColor = Color.Green;
                cTextRepass.BorderColor = Color.Green;
                cTextRepass.BorderFocusColor = Color.Green;
                label8.Visible = false;
            }
            else
            {
                cBtnOK.Enabled = false;
                cTextNewPass.BorderColor = Color.Red;
                cTextNewPass.BorderFocusColor = Color.Red;
                cTextRepass.BorderColor = Color.Red;
                cTextRepass.BorderFocusColor = Color.Red;
                label8.Visible = true;
            }
        }
    }
}
