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

namespace QLNS.Views.ViewBill
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();

            //init data
            cTextIdBill.Texts = BLL_Bill.Instance.GetIDNewBill().ToString();
            cTextIdStaff.Texts = BLL_Login.Instance.GetStaff().ID_Staff.ToString();
            setCBBPayment();
        }

        private void setCBBPayment()
        {
            cbPayment.Items.AddRange(BLL_Bill.Instance.GetListCBBPayment().ToArray());
        }

        private void cBtnAddBook_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();

            AddBookForBill fbook = new AddBookForBill();
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
                fbook.d = new AddBookForBill.Mydel(loadData);
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

        private void loadData()
        {
            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Bill.Instance.GetListBookInNewBill().Count == 0)
            {
                dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                dataGridViewBookOrder.Columns.Add("Author", "Author");
                dataGridViewBookOrder.Columns.Add("Category", "Category");
                dataGridViewBookOrder.Columns.Add("Publisher", "Publisher");
                dataGridViewBookOrder.Columns.Add("PublishingYear", "Publishing year");
                dataGridViewBookOrder.Columns.Add("Edition", "Edition");
                dataGridViewBookOrder.Columns.Add("Quantity", "Quantity");
                dataGridViewBookOrder.Columns.Add("OriginalPrice", "Original price(VND)");
                dataGridViewBookOrder.Columns.Add("Discount", "Discount(%)");
                dataGridViewBookOrder.Columns.Add("RealPrice", "Real price(VND)");
            }
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Bill.Instance.GetListBookInNewBill();
                dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Author";
                dataGridViewBookOrder.Columns[3].HeaderText = "Category";
                dataGridViewBookOrder.Columns[4].HeaderText = "Publisher";
                dataGridViewBookOrder.Columns[5].HeaderText = "Publishing year";
                dataGridViewBookOrder.Columns[6].HeaderText = "Edition";
                dataGridViewBookOrder.Columns[7].HeaderText = "Quantity";
                dataGridViewBookOrder.Columns[8].HeaderText = "Original Price(VND)";
                dataGridViewBookOrder.Columns[9].HeaderText = "Discount(%)";
                dataGridViewBookOrder.Columns[10].HeaderText = "Real Price(VND)";
            }

            lbTotalCost.Text = BLL_Bill.Instance.GetTotalCostNewBill().ToString();
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
                        BLL_Bill.Instance.RemoveBookInBill(idBook);
                    }
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            BLL_Bill.Instance.ReturnRemainAmountDB();
            this.Close();
        }

        private void cBtnSaveAndPrint_Click(object sender, EventArgs e)
        {
            // check data
            if (cTextCustomerName.Texts == "")
            {
                MessageBox.Show("Please enter customer's name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cTextCustomerName.Focus();
                return;
            }
            if (cbPayment.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose payment method", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbPayment.Focus();
                return;
            }
            cTextCustomerName.Texts = cTextCustomerName.Texts.Trim(); // bỏ khoảng trắng thừa

            // tạo đối tượng Bill và Detail_Bill add vào db
            if (BLL_Bill.Instance.GetListBookInNewBill().Count == 0)
            {
                MessageBox.Show("You have not added any books yet. Please add some books", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cBtnAddBook.Focus();
                return;
            }
            Bill bill = new Bill();
            try
            {
                bill.ID_Bill = Convert.ToInt32(cTextIdBill.Texts);
                bill.NameCustomer = cTextCustomerName.Texts;
                bill.DatePay = dateTimePickerOrder.Value.Date;
                bill.TotalCost = Convert.ToDecimal(lbTotalCost.Text);
                bill.ID_Staff = Convert.ToInt32(cTextIdStaff.Texts);
                bill.ID_Payment = ((CBBItem)cbPayment.SelectedItem).Value;
                BLL_Bill.Instance.AddNewBill(bill);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (dynamic i in BLL_Bill.Instance.GetListBookInNewBill())
            {
                int idBill = Convert.ToInt32(cTextIdBill.Texts);
                Detail_Bill detailBill = new Detail_Bill
                {
                    ID_Bill = idBill,
                    ID_Book = i.ID_Book,
                    Amount = i.Quantity,
                    Price = i.RealPrice
                };
                BLL_Bill.Instance.AddNewDetailBill(detailBill);
            }

            //print invoice
            BLL_Bill.Instance.PrintBill(bill);

            //clear List
            BLL_Bill.Instance.ClearList();
            
            // Thông báo thành công
            MessageBox.Show("Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
