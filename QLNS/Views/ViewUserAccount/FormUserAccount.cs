using QLNS.BLL;
using QLNS.DTO;
using QLNS.Views.ViewBook;
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
    public partial class FormUserAccount : Form
    {
        public FormUserAccount()
        {
            InitializeComponent();

            SetCBBRole();
            SetCBBSort();
            LoadData();
        }

        private void SetCBBRole()
        {
            cbRole.Items.Clear();
            cbRole.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbRole.Items.AddRange(BLL_User.Instance.GetListCBBRole().ToArray());
            cbRole.SelectedIndex = 0;
        }

        private void SetCBBSort()
        {
            cbSort.Items.Clear();
            cbSort.Items.AddRange(new string[] { "ID", "Name", "Date of birth", "Phone number", "Email", "Address" });
        }

        private void LoadData(string textSearch = "", int idRole = 0)
        {
            dataGridViewListOfStaff.Columns.Clear();
            if (BLL_User.Instance.GetListUserView(textSearch, idRole).Count > 0)
            {
                dataGridViewListOfStaff.DataSource = BLL_User.Instance.GetListUserView(textSearch, idRole);
            }
            else
            {
                MessageBox.Show("No data found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbRole.SelectedIndex = 0;
                if (BLL_User.Instance.GetListUserView("", 0).Count == 0)
                {
                    dataGridViewListOfStaff.DataSource = null;
                    dataGridViewListOfStaff.Columns.Add("IDStaff", "Staff's ID");
                    dataGridViewListOfStaff.Columns.Add("NameStaffe", "Staff's name");
                    dataGridViewListOfStaff.Columns.Add("Gender", "Gender");
                    dataGridViewListOfStaff.Columns.Add("DateOfBirth", "Date of birth");
                    dataGridViewListOfStaff.Columns.Add("PhoneNumber", "Phone number");
                    dataGridViewListOfStaff.Columns.Add("Email", "Email");
                    dataGridViewListOfStaff.Columns.Add("Address", "Address");
                    dataGridViewListOfStaff.Columns.Add("Role", "Role");
                    return;
                }   
                else
                {
                    dataGridViewListOfStaff.DataSource = BLL_User.Instance.GetListUserView("", 0);
                }    
            }
            dataGridViewListOfStaff.Columns[0].HeaderText = "Staff's ID";
            dataGridViewListOfStaff.Columns[1].HeaderText = "Staff's name";
            dataGridViewListOfStaff.Columns[2].HeaderText = "Gender";
            dataGridViewListOfStaff.Columns[3].HeaderText = "Date of birth";
            dataGridViewListOfStaff.Columns[4].HeaderText = "Phone number";
            dataGridViewListOfStaff.Columns[5].HeaderText = "Email";
            dataGridViewListOfStaff.Columns[6].HeaderText = "Address";
            dataGridViewListOfStaff.Columns[7].HeaderText = "Role";
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            AddUserAccount fbook = new AddUserAccount();
            try
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = Color.Gray;
                formBackground.Size = FormBook.ActiveForm.Size;
                formBackground.TopMost = false;
                formBackground.Location = FormBook.ActiveForm.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                fbook.Owner = formBackground;
                fbook.StartPosition = FormStartPosition.CenterScreen;
                fbook.d = new AddUserAccount.Mydel(LoadData);
                fbook.ShowDialog();
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

        private void iBtnResetPass_Click(object sender, EventArgs e)
        {
            if (dataGridViewListOfStaff.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to reset password to default password : User@123?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewListOfStaff.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["ID_Staff"].Value);
                        if (id == 1 && BLL_Login.Instance.GetStaff().ID_Staff != 1)
                        {
                            MessageBox.Show("You can't reset password of this admin", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            continue;
                        }
                        BLL_Login.Instance.ResetPassword(id);
                    }
                    MessageBox.Show("Done!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData("", ((CBBItem)cbRole.SelectedItem).Value);
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            if (cTextBoxSearch.Texts != "")
                LoadData(cTextBoxSearch.Texts.Trim(), ((CBBItem)cbRole.SelectedItem).Value);
            else
                LoadData("", ((CBBItem)cbRole.SelectedItem).Value);
        }

        private void iBtnSort_Click(object sender, EventArgs e)
        {
            List<dynamic> data = BLL_User.Instance.GetListUserView(cTextBoxSearch.Texts, ((CBBItem)cbRole.SelectedItem).Value);
            if (cbSort.SelectedItem != null)
            {
                string sort = cbSort.SelectedItem.ToString();
                dataGridViewListOfStaff.DataSource = BLL_User.Instance.SortListUserView(data, sort);
            }
        }

        private void iBtnDeleteUserAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewListOfStaff.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete those staffs?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewListOfStaff.SelectedRows)
                    {
                        int idStaff = Convert.ToInt32(row.Cells["ID_Staff"].Value);
                        if (idStaff == 1)
                        {
                            MessageBox.Show("You can't delete this admin", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            continue;
                        }
                        BLL_User.Instance.DeleteUserByIDStaff(idStaff);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
