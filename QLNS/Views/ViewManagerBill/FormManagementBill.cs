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

namespace QLNS.Views.ViewManagerBill
{
    public partial class FormManagementBill : Form
    {
        public FormManagementBill()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string textSearch = "")
        {
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Bill.Instance.GetListBillView(textSearch).Count > 0)
            {
                dataGridViewBookOrder.DataSource = BLL_Bill.Instance.GetListBillView(textSearch);
            }
            else
            {
                MessageBox.Show("No data found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (BLL_Bill.Instance.GetListBillView("").Count == 0)
                {
                    dataGridViewBookOrder.DataSource = null;
                    dataGridViewBookOrder.Columns.Add("IDBill", "Bill's ID");
                    dataGridViewBookOrder.Columns.Add("IDStaff", "Staff's ID");
                    dataGridViewBookOrder.Columns.Add("NameCustomer", "Customer's Name");
                    dataGridViewBookOrder.Columns.Add("Date", "Date");
                    dataGridViewBookOrder.Columns.Add("PaymentMethod", "Payment Method");
                    dataGridViewBookOrder.Columns.Add("Total", "Total(VND)");
                    return;
                }
                else
                {
                    dataGridViewBookOrder.DataSource = BLL_Bill.Instance.GetListBillView("");
                }
            }
            dataGridViewBookOrder.Columns[0].HeaderText = "Bill's ID";
            dataGridViewBookOrder.Columns[1].HeaderText = "Staff's ID";
            dataGridViewBookOrder.Columns[2].HeaderText = "Customer's Name";
            dataGridViewBookOrder.Columns[3].HeaderText = "Date";
            dataGridViewBookOrder.Columns[4].HeaderText = "Payment Method";
            dataGridViewBookOrder.Columns[5].HeaderText = "Total(VND)";
        }

        private void iBtnDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookOrder.SelectedRows.Count == 1)
            {
                Form formBackground = new Form();
                int idBill = Convert.ToInt32(dataGridViewBookOrder.SelectedRows[0].Cells["ID_Bill"].Value);
                DetailBill DetailBill = new DetailBill(idBill);
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

                    DetailBill.Owner = formBackground;
                    DetailBill.StartPosition = FormStartPosition.CenterScreen;
                    DetailBill.ShowDialog();
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

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            if (cTextCustomerName.Texts != "")
            {
                LoadData(cTextCustomerName.Texts);
            }    
            else
            {
                MessageBox.Show("Please enter customer's name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
            }
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookOrder.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete these bills?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BLL_Login.Instance.GetRole().ID_Role != 1)
                    {
                        MessageBox.Show("You do not have permission to delete these bills!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    foreach (DataGridViewRow row in dataGridViewBookOrder.SelectedRows)
                    {
                        int idBill = Convert.ToInt32(row.Cells["ID_Bill"].Value);
                        BLL_Bill.Instance.DeleteBill(idBill);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dataGridViewBookOrder.Rows.Count == 0)
            {
                dataGridViewBookOrder.Columns.Clear();
            }
        }
    }
}
