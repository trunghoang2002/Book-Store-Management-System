using QLNS.BLL;
using QLNS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Views.ViewUserAccount
{
    public partial class AddUserAccount : Form
    {
        public delegate void Mydel(string textSearch = "", int idRole = 0);
        public Mydel d;
        public AddUserAccount()
        {
            InitializeComponent();

            SetCBBRole();
            LoadData();
        }

        private void SetCBBRole()
        {
            cbRole.Items.Clear();
            cbRole.Items.AddRange(BLL_User.Instance.GetListCBBRole().ToArray());
        }

        private void LoadData()
        {
            cTextBoxIdStaff.Texts = BLL_User.Instance.GetIDNewStaff().ToString();
            cTextBoxIdAccount.Texts = BLL_User.Instance.GetIDNewAccount().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBtnSave_Click(object sender, EventArgs e)
        {
            if (cTextBoxStaffName.Texts == "")
            {
                MessageBox.Show("Please enter staff name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxStaffName.Focus();
                return;
            }
            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                MessageBox.Show("Please choose gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cTextBoxAddress.Texts == "")
            {
                MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxAddress.Focus();
                return;
            }
            if (cTextBoxPhonenumber.Texts == "")
            {
                MessageBox.Show("Please enter phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxPhonenumber.Focus();
                return;
            }
            if (cTextBoxPhonenumber.Texts.Length != 10 || cTextBoxPhonenumber.Texts.Substring(0, 1) != "0" || cTextBoxPhonenumber.Texts.All(char.IsDigit) == false)
            {
                MessageBox.Show("Phone numbers must have the following format: 10 digits and starting with 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxPhonenumber.Focus();
                return;
            }
            if (cTextBoxEmail.Texts == "")
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxEmail.Focus();
                return;
            }
            if (cTextBoxEmail.Texts.Contains("@") == false || cTextBoxEmail.Texts.Contains(".") == false)
            {
                MessageBox.Show("Please enter email with the right format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxEmail.Focus();
                return;
            }
            if (cbRole.SelectedItem == null)
            {
                MessageBox.Show("Please choose role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbRole.Focus();
                return;
            }
            if (cTextBoxUserName.Texts == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxUserName.Focus();
                return;
            }
            if (cTextBoxPassword.Texts == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxPassword.Focus();
                return;
            }
            if (cTextBoxPassword.Texts.Length < 6)
            {
                MessageBox.Show("The password must be at least 6 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cTextBoxPassword.Texts.Length > 20)
            {
                MessageBox.Show("The password must be less than 20 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cTextBoxPassword.Texts.Any(char.IsDigit) == false)
            {
                MessageBox.Show("The password must contain at least one digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cTextBoxPassword.Texts.Any(char.IsUpper) == false)
            {
                MessageBox.Show("The password must contain at least one uppercase letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cTextBoxPassword.Texts.Any(char.IsLower) == false)
            {
                MessageBox.Show("The password must contain at least one lowercase letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newpass = BLL_Login.Instance.EncodePass(cTextBoxPassword.Texts);
            User_Account account = new User_Account
            {
                ID_Account = Convert.ToInt32(cTextBoxIdAccount.Texts),
                UserName = cTextBoxUserName.Texts,
                Password = newpass,
                ID_Role = ((CBBItem)cbRole.SelectedItem).Value
            };
            Staff staff = new Staff
            {
                ID_Staff = Convert.ToInt32(cTextBoxIdStaff.Texts),
                NameStaff = cTextBoxStaffName.Texts,
                Gender = rbMale.Checked,
                DateOfBirth = dateTimePickerBirthDay.Value.Date,
                Address = cTextBoxAddress.Texts,
                PhoneNumber = cTextBoxPhonenumber.Texts,
                Email = cTextBoxEmail.Texts,
                ID_Account = Convert.ToInt32(cTextBoxIdAccount.Texts)
            };

            BLL_User.Instance.AddUserAccount(account);
            BLL_User.Instance.AddStaff(staff);
            
            MessageBox.Show("Save successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            d();
            this.Close();
        }
    }
}
