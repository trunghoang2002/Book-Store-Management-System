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

namespace QLNS.Views.ViewUser
{
    public partial class EditInforUser : Form
    {
        public delegate void Mydel();
        public Mydel d;
        int idStaff;
        public EditInforUser(int idStaff)
        {
            InitializeComponent();
            this.idStaff = idStaff;

            LoadData();
        }
        
        private void LoadData()
        {
            Staff staff = BLL_User.Instance.GetStaffByID(idStaff);
            cTextBoxIdStaff.Texts = staff.ID_Staff.ToString();
            cTextBoxStaffName.Texts = staff.NameStaff;
            if (staff.Gender) rbMale.Checked = true;
            else rbFemale.Checked = true;
            dateTimePickerBirthDay.Value = staff.DateOfBirth;
            cTextBoxAddress.Texts = staff.Address;
            cTextBoxPhonenumber.Texts = staff.PhoneNumber;
            cTextBoxEmail.Texts = staff.Email;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (cTextBoxAddress.Texts == "")
            {
                MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxAddress.Focus();
                return;
            }

            int idAccount = BLL_User.Instance.GetAccountByIDStaff(idStaff).ID_Account;
            Staff staff = new Staff
            {
                ID_Staff = Convert.ToInt32(cTextBoxIdStaff.Texts),
                NameStaff = cTextBoxStaffName.Texts,
                Gender = rbMale.Checked,
                DateOfBirth = dateTimePickerBirthDay.Value.Date,
                Address = cTextBoxAddress.Texts,
                PhoneNumber = cTextBoxPhonenumber.Texts,
                Email = cTextBoxEmail.Texts,
                ID_Account = idAccount
            };
            BLL_User.Instance.UpdateStaff(staff);
            
            MessageBox.Show("Save successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            d();
            this.Close();
        }
    }
}
