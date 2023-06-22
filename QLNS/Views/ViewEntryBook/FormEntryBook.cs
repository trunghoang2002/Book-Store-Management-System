using QLNS.BLL;
using QLNS.Views.ViewBill;
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

namespace QLNS.Views.ViewEntryBook
{
    public partial class FormEntryBook : Form
    {
        public FormEntryBook()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListBook(BLL_Login.Instance.GetStaff().ID_Staff, DateTime.Now.Date).Count == 0)
            {
                dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                dataGridViewBookOrder.Columns.Add("Quantity", "Quantity");
                dataGridViewBookOrder.Columns.Add("CostPrice", "Cost price(VND)");
            }    
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBook(BLL_Login.Instance.GetStaff().ID_Staff, DateTime.Now.Date);
                dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Quantity";
                dataGridViewBookOrder.Columns[3].HeaderText = "Cost Price(VND)";
            }    
        }

        private void cBtnAddBook_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            AddBookForEntry fbook = new AddBookForEntry();
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

                fbook.Owner = formBackground;
                fbook.StartPosition = FormStartPosition.CenterScreen;
                fbook.d = new AddBookForEntry.Mydel(LoadData);
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

        private void cBtnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookOrder.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to remove these books?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewBookOrder.SelectedRows)
                    {
                        int idBook = Convert.ToInt32(row.Cells["ID_Book"].Value);
                        BLL_Book.Instance.RemoveBookFromList(idBook);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cBtnSaveAndPrint_Click(object sender, EventArgs e)
        {
            if (BLL_Book.Instance.GetListBook(BLL_Login.Instance.GetStaff().ID_Staff, DateTime.Now.Date).Count == 0)
            {
                MessageBox.Show("You have not added any books yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL_Book.Instance.AddListBookToWarehouse(BLL_Login.Instance.GetStaff().ID_Staff, DateTime.Now.Date);
            BLL_Book.Instance.ClearList();

            MessageBox.Show("Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            BLL_Book.Instance.ClearList();
            this.Close();
        }
    }
}
