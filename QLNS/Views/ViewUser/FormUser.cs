using QLNS.BLL;
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

namespace QLNS.Views.ViewUser
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            setLabel();
        }

        private void setLabel()
        {
            lbIDUser.Text = BLL_Login.Instance.GetStaff().ID_Staff.ToString();
            lbNameUser.Text = BLL_Login.Instance.GetStaff().NameStaff;
            if (BLL_Login.Instance.GetStaff().Gender)
            {
                lbGenderUser.Text = "Nam";
            }
            else
            {
                lbGenderUser.Text = "Nữ";
            }
            lbDoBUser.Text = BLL_Login.Instance.GetStaff().DateOfBirth.ToString("dd/MM/yyyy");
            lbAddressUser.Text = BLL_Login.Instance.GetStaff().Address;
            lbPhoneUser.Text = BLL_Login.Instance.GetStaff().PhoneNumber;
            lbMailUser.Text = BLL_Login.Instance.GetStaff().Email;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            ChangePassword fpass = new ChangePassword();
            try
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = Color.Gray;
                formBackground.Size = FormAdmin.ActiveForm.Size;
                formBackground.TopMost = false;
                formBackground.Location = FormAdmin.ActiveForm.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                fpass.Owner = formBackground;
                fpass.StartPosition = FormStartPosition.CenterScreen;
                fpass.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            int idStaff = BLL_Login.Instance.GetStaff().ID_Staff;
            EditInforUser feditInforUser = new EditInforUser(idStaff);
            try
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = Color.Gray;
                formBackground.Size = FormAdmin.ActiveForm.Size;
                formBackground.TopMost = false;
                formBackground.Location = FormAdmin.ActiveForm.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                feditInforUser.Owner = formBackground;
                feditInforUser.StartPosition = FormStartPosition.CenterScreen;
                feditInforUser.d = new EditInforUser.Mydel(setLabel);
                feditInforUser.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
    }
}
