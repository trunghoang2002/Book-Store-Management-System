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

namespace QLNS.Views.ViewBill
{
    public partial class AddBookForBill : Form
    {
        public delegate void Mydel();
        public Mydel d;
        public AddBookForBill()
        {
            InitializeComponent();

            // Set CBB
            SetCBBCategory();
        }

        private void LoadData(string textSearch = "", int idCategory = 0)
        {
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListBookView(textSearch, idCategory).Count > 0)
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBookView(textSearch, idCategory);
            }
            else
            {
                MessageBox.Show("No book found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCategory.SelectedIndex = 0;
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBookView("", 0);
            }
            dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
            dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
            dataGridViewBookOrder.Columns[2].HeaderText = "Author";
            dataGridViewBookOrder.Columns[3].HeaderText = "Category";
            dataGridViewBookOrder.Columns[4].HeaderText = "Publisher";
            dataGridViewBookOrder.Columns[5].HeaderText = "Publishing year";
            dataGridViewBookOrder.Columns[6].HeaderText = "Edition";
            dataGridViewBookOrder.Columns[7].HeaderText = "Remaining amount";
            dataGridViewBookOrder.Columns[8].HeaderText = "Original Price(VND)";
            dataGridViewBookOrder.Columns[9].HeaderText = "Discount(%)";
            dataGridViewBookOrder.Columns[10].HeaderText = "Real Price(VND)";
        }

        private void SetCBBCategory()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add(new CBBItem { Text = "All", Value = 0 });
            cbCategory.Items.AddRange(BLL_Book.Instance.GetListCBBCategory().ToArray());
            cbCategory.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBtnAddBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookOrder.SelectedRows.Count == 1)
            {
                if (cTextBoxQuantity.Texts == "")
                {
                    MessageBox.Show("Please enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cTextBoxQuantity.Focus();
                }
                else
                {
                    int quantity = Convert.ToInt32(cTextBoxQuantity.Texts.Trim());
                    if (quantity <= 0)
                    {
                        MessageBox.Show("Quantity must greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cTextBoxQuantity.Focus();
                        return;
                    }
                    int bookID = Convert.ToInt32(dataGridViewBookOrder.SelectedRows[0].Cells["ID_Book"].Value);
                    try
                    {
                        BLL_Bill.Instance.CheckBookAmount(bookID, quantity); // throw exception if not enough book in stock

                        if (BLL_Bill.Instance.CheckBookInBill(bookID))
                        {
                            DialogResult result = MessageBox.Show("This book is already in bill. Do you want to continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (result == DialogResult.Cancel)
                                return;
                        }
                        BLL_Bill.Instance.AddBookToBill(bookID, quantity);
                        d();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            if (cTextBoxSearch.Texts != "")
                LoadData(cTextBoxSearch.Texts.Trim(), ((CBBItem)cbCategory.SelectedItem).Value);
            else
                LoadData("", ((CBBItem)cbCategory.SelectedItem).Value);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData("", ((CBBItem)cbCategory.SelectedItem).Value);
        }
    }
}
