using QLNS.BLL;
using QLNS.Views.ViewDashboard;
using QLNS.Views.ViewManagerBill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Views.ViewRevenueAdmin
{
    public partial class FormRevenueAdmin : Form
    {
        private Button currentButton;
        public FormRevenueAdmin()
        {
            InitializeComponent();
            GUI();            
        }

        private void GUI()
        {
            //Default - last 7 day
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            cBtnLast7day.Select();
            SetDateMenuButtonsUI(cBtnLast7day);
        }

        private void LoadData(object sender, EventArgs e)
        {
            if (rbSalesman.Checked) rbSalesman_CheckedChanged(sender, e);
            if (rbBook.Checked) rbBook_CheckedChanged(sender, e);
            if (rbCategory.Checked) rbCategory_CheckedChanged(sender, e);
        }

        private void SetDateMenuButtonsUI(object button)
        {
            var btn = (Button)button;
            //highlight button
            btn.BackColor = cBtnLast30day.BorderColor;
            btn.ForeColor = Color.White;
            //unhiglight button
            if (currentButton != null && currentButton !=btn)
            {
                currentButton.BackColor = Color.FromArgb(238,238,238);
                currentButton.ForeColor = Color.FromArgb(64,64,64);
            }
            currentButton = btn;
            //Enable custom button
            if (currentButton==cBtnCustom)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                cBtnCustomOk.Visible = true;
                lbStartDate.Cursor = Cursors.Hand;
                lbEndDate.Cursor = Cursors.Hand;
            }
            //disable custom button
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                cBtnCustomOk.Visible = false;
                lbStartDate.Cursor = Cursors.Default;
                lbEndDate.Cursor = Cursors.Default;
            }
        }

        private void cBtnThismonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData(sender, e);
            SetDateMenuButtonsUI(sender);
        }

        private void cBtnLast30day_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData(sender, e);
            SetDateMenuButtonsUI(sender);
        }

        private void cBtnLast7day_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData(sender, e);
            SetDateMenuButtonsUI(sender);
        }

        private void cBtnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData(sender, e);
            SetDateMenuButtonsUI(sender);
        }

        private void cBtnCustom_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
        }

        private void lbStartDate_Click(object sender, EventArgs e)
        {
            if (currentButton==cBtnCustom)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lbEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == cBtnCustom)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                MessageBox.Show("Start date must be less than or equal to end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpStartDate.Value = dtpEndDate.Value;
            }
            else
            {
                LoadData(sender, e);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lbEndDate.Text = dtpEndDate.Text;
            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                MessageBox.Show("End date must be greater than or equal to start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpEndDate.Value = dtpStartDate.Value;
            }
            else
            {
                LoadData(sender, e);
            }
        }

        private void FormRevenueAdmin_Load(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
            lbEndDate.Text = dtpEndDate.Text;
        }

        private void rbSalesman_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            DateTime date1 = dtpStartDate.Value.Date;
            DateTime date2 = dtpEndDate.Value.Date;
            if (BLL_Revenue.Instance.GetListBillFromDateToDate(date1, date2).Count == 0)
            {
                dataGridViewBookOrder.Columns.Add("IDill", "Bill's ID");
                dataGridViewBookOrder.Columns.Add("NameCustomer", "Customer's name");
                dataGridViewBookOrder.Columns.Add("Date", "Date");
                dataGridViewBookOrder.Columns.Add("TotalPrice", "Total price");
                dataGridViewBookOrder.Columns.Add("IDStaff", "Staff's ID");
                dataGridViewBookOrder.Columns.Add("NameStaff", "Staff's name");
                dataGridViewBookOrder.Columns.Add("PaymentMethod", "Payment method");
            }    
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Revenue.Instance.GetListBillFromDateToDate(date1, date2);
                dataGridViewBookOrder.Columns[0].HeaderText = "Bill's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Customer's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Date";
                dataGridViewBookOrder.Columns[3].HeaderText = "Total price";
                dataGridViewBookOrder.Columns[4].HeaderText = "Staff's ID";
                dataGridViewBookOrder.Columns[5].HeaderText = "Staff's name";
                dataGridViewBookOrder.Columns[6].HeaderText = "Payment method";
            }    

            LoadLabel(date1, date2);
            if (rbSalesman.Checked) icbDetailBill.Enabled = true;
            else icbDetailBill.Enabled = false;
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            DateTime date1 = dtpStartDate.Value.Date;
            DateTime date2 = dtpEndDate.Value.Date;
            if (BLL_Revenue.Instance.GetListBillFromDateToDateByBook(date1, date2).Count == 0)
            {
                dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                dataGridViewBookOrder.Columns.Add("TotalAmount", "Total amount");
                dataGridViewBookOrder.Columns.Add("TotalPrice", "Total price");
            }
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Revenue.Instance.GetListBillFromDateToDateByBook(date1, date2);
                dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Total amount";
                dataGridViewBookOrder.Columns[3].HeaderText = "Total price";
            }    

            LoadLabel(date1, date2);
        }

        private void rbCategory_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            DateTime date1 = dtpStartDate.Value.Date;
            DateTime date2 = dtpEndDate.Value.Date;
            if (BLL_Revenue.Instance.GetListBillFromDateToDateByCategory(date1, date2).Count == 0)
            {
                dataGridViewBookOrder.Columns.Add("IDCategory", "Category's ID");
                dataGridViewBookOrder.Columns.Add("NameCategory", "Category's name");
                dataGridViewBookOrder.Columns.Add("TotalAmount", "Total amount");
                dataGridViewBookOrder.Columns.Add("TotalPrice", "Total price");
            }
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Revenue.Instance.GetListBillFromDateToDateByCategory(date1, date2);
                dataGridViewBookOrder.Columns[0].HeaderText = "Category's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Category's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Total amount";
                dataGridViewBookOrder.Columns[3].HeaderText = "Total price";
            }    

            LoadLabel(date1, date2);
        }

        private void LoadLabel(DateTime date1, DateTime date2)
        {
            lbTotalBill.Text = BLL_Revenue.Instance.GetListBillFromDateToDate(date1, date2).Count.ToString();
            lbTotalRevenue.Text = BLL_Revenue.Instance.GetTotalRevenueAdmin(date1, date2).ToString();
            lbTotalProfit.Text = BLL_Revenue.Instance.GetTotalProfit(date1, date2).ToString();
        }

        private void icbDetailBill_Click(object sender, EventArgs e)
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
    }
}
