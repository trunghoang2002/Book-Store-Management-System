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

namespace QLNS.Views.ViewEntryDiary
{
    public partial class EntryDiaryBook : Form
    {
        public EntryDiaryBook()
        {
            InitializeComponent();
        }

        private void LoadData(string nameStaff = "")
        {
            DateTime date1 = dateTimePickerFirst.Value.Date;
            DateTime date2 = dateTimePickerSecond.Value.Date;

            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListEntryDiary(date1, date2, nameStaff).Count == 0)
            {
                dataGridViewBookOrder.Columns.Add("IDStaff", "Staff's ID");
                dataGridViewBookOrder.Columns.Add("NameStaff", "Staff's name");
                dataGridViewBookOrder.Columns.Add("DateEntry", "Date entry");
                dataGridViewBookOrder.Columns.Add("TotalQuantity", "Total quantity");
                dataGridViewBookOrder.Columns.Add("TotalCost", "Total cost");
            }
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListEntryDiary(date1, date2, nameStaff);
                dataGridViewBookOrder.Columns[0].HeaderText = "Staff's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Staff's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Date entry";
                dataGridViewBookOrder.Columns[3].HeaderText = "Total quantity";
                dataGridViewBookOrder.Columns[4].HeaderText = "Total cost";
            }

            lbTotalPurcharedB.Text = BLL_Book.Instance.GetTotalAmount(date1, date2, nameStaff).ToString();
            lbExpense.Text = BLL_Book.Instance.GetTotalExpense(date1, date2, nameStaff).ToString();
        }

        private void iBtnDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookOrder.SelectedRows.Count == 1)
            {
                Form formBackground = new Form();
                int idStaff = Convert.ToInt32(dataGridViewBookOrder.SelectedRows[0].Cells["ID_Staff"].Value);
                DateTime dateEntry = Convert.ToDateTime(dataGridViewBookOrder.SelectedRows[0].Cells["DateEntry"].Value).Date;
                DetailEntryBook detailEntryBook = new DetailEntryBook(idStaff, dateEntry);
                try
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Gray;
                    formBackground.Size = FormSalePerson.ActiveForm.Size;
                    formBackground.TopMost = false;
                    formBackground.Location = FormSalePerson.ActiveForm.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    detailEntryBook.Owner = formBackground;
                    detailEntryBook.StartPosition = FormStartPosition.CenterScreen;
                    detailEntryBook.ShowDialog();
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
            else
            {
                MessageBox.Show("Please select only one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookOrder.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this entry?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (BLL_Login.Instance.GetRole().ID_Role != 1)
                    {
                        MessageBox.Show("You do not have permission to delete these entries!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    foreach (DataGridViewRow i in dataGridViewBookOrder.SelectedRows)
                    {
                        int idStaff = Convert.ToInt32(i.Cells["ID_Staff"].Value);
                        DateTime date = Convert.ToDateTime(i.Cells["DateEntry"].Value).Date;
                        BLL_Book.Instance.DeleteEntryDiary(idStaff, date);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            if (cTextNameStaff.Texts != "")
            {
                LoadData(cTextNameStaff.Texts);
            }
            else
            {
                MessageBox.Show("Please enter Staff's name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePickerFirst_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerSecond.Value.Date < dateTimePickerFirst.Value.Date)
            {
                MessageBox.Show("Start date must be less than or equal to end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerFirst.Value = dateTimePickerSecond.Value;
            }
            else
            {
                LoadData();
            }
        }

        private void dateTimePickerSecond_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerSecond.Value.Date < dateTimePickerFirst.Value.Date)
            {
                MessageBox.Show("End date must be greater than or equal to start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerSecond.Value = dateTimePickerFirst.Value;
            }
            else
            {
                LoadData();
            }    
        }
    }
}
