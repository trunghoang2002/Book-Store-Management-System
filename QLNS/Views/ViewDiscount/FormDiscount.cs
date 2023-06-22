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

namespace QLNS.Views.ViewDiscount
{
    public partial class FormDiscount : Form
    {
        public FormDiscount()
        {
            InitializeComponent();
            LoadData();
            SetCBBSort();
        }

        private void SetCBBSort()
        {
            cbSort.Items.Clear();
            cbSort.Items.AddRange(new string[] { "ID", "Name", "Author", "Publisher", "Publishing year", "Cost price", "Selling price", "Discount", "Real price" });
        }

        private void LoadData(string textSearch = "")
        {
            dataGridViewLisfOfDiscount.Columns.Clear();
            if (BLL_Book.Instance.GetListBookViewDiscount(textSearch).Count > 0)
            {
                dataGridViewLisfOfDiscount.DataSource = BLL_Book.Instance.GetListBookViewDiscount(textSearch);
            }
            else
            {
                MessageBox.Show("No data found!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (BLL_Book.Instance.GetListBookViewDiscount("").Count == 0)
                {
                    dataGridViewLisfOfDiscount.DataSource = null;
                    dataGridViewLisfOfDiscount.Columns.Add("IDBook", "Book's ID");
                    dataGridViewLisfOfDiscount.Columns.Add("NameBook", "Book's name");
                    dataGridViewLisfOfDiscount.Columns.Add("Author", "Author");
                    dataGridViewLisfOfDiscount.Columns.Add("Category", "Category");
                    dataGridViewLisfOfDiscount.Columns.Add("Publisher", "Publisher");
                    dataGridViewLisfOfDiscount.Columns.Add("PublishingYear", "Publishing year");
                    dataGridViewLisfOfDiscount.Columns.Add("Edition", "Edition");
                    dataGridViewLisfOfDiscount.Columns.Add("CostPrice", "Cost price(VND)");
                    dataGridViewLisfOfDiscount.Columns.Add("SellingPrice(VND)", "Selling price(VND)");
                    dataGridViewLisfOfDiscount.Columns.Add("Discount", "Discount(%)");
                    dataGridViewLisfOfDiscount.Columns.Add("RealPrice", "Real price(VND)");
                    return;
                } 
                else
                {
                    dataGridViewLisfOfDiscount.DataSource = BLL_Book.Instance.GetListBookViewDiscount("");
                }  
            }
            dataGridViewLisfOfDiscount.Columns[0].HeaderText = "Book's ID";
            dataGridViewLisfOfDiscount.Columns[1].HeaderText = "Book's name";
            dataGridViewLisfOfDiscount.Columns[2].HeaderText = "Author";
            dataGridViewLisfOfDiscount.Columns[3].HeaderText = "Category";
            dataGridViewLisfOfDiscount.Columns[4].HeaderText = "Publisher";
            dataGridViewLisfOfDiscount.Columns[5].HeaderText = "Publishing year";
            dataGridViewLisfOfDiscount.Columns[6].HeaderText = "Edition";
            dataGridViewLisfOfDiscount.Columns[7].HeaderText = "Cost Price(VND)";
            dataGridViewLisfOfDiscount.Columns[8].HeaderText = "Selling Price(VND)";
            dataGridViewLisfOfDiscount.Columns[9].HeaderText = "Discount(%)";
            dataGridViewLisfOfDiscount.Columns[10].HeaderText = "Real price(VND)";
        }

        private void LoadDataBook(int idBook)
        {
            Book book = BLL_Book.Instance.GetBookByID(idBook);
            cTextBoxIdBook.Texts = book.ID_Book.ToString();
            cTextBoxBookName.Texts = book.NameBook;
            cTextBoxSellingPrice.Texts = book.SellingPrice.ToString();
            Book_Discount book_Discount = BLL_Book.Instance.GetDiscountByID(idBook);
            cTextBoxDiscount.Texts = book_Discount.Discount.ToString();
            cTextBoxPriceAfterDiscount.Texts = (book.SellingPrice * (1 - book_Discount.Discount / 100)).ToString();
        }

        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLisfOfDiscount.SelectedRows.Count == 1)
            {
                int idBook = Convert.ToInt32(dataGridViewLisfOfDiscount.SelectedRows[0].Cells["ID_Book"].Value);
                LoadDataBook(idBook);
            }
            else
            {
                MessageBox.Show("Please select only one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLisfOfDiscount.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete those discounts?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewLisfOfDiscount.SelectedRows)
                    {
                        int idBook = Convert.ToInt32(row.Cells["ID_Book"].Value);
                        BLL_Book.Instance.DeleteDiscount(idBook);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iBtnSort_Click(object sender, EventArgs e)
        {
            List<dynamic> data = BLL_Book.Instance.GetListBookViewDiscount();
            if (cbSort.SelectedItem != null)
            {
                string sort = cbSort.SelectedItem.ToString();
                dataGridViewLisfOfDiscount.DataSource = BLL_Book.Instance.SortListBookView(data, sort);
            }
        }

        private void cBtnSave_Click(object sender, EventArgs e)
        {
            int idBook = Convert.ToInt32(cTextBoxIdBook.Texts);
            decimal discount = Convert.ToDecimal(cTextBoxDiscount.Texts);
            if (BLL_Book.Instance.CheckDiscountExist(idBook))
            {
                BLL_Book.Instance.UpdateDiscount(idBook, discount);
            }    
            else
            {
                BLL_Book.Instance.AddNewDiscount(idBook, discount);
            }    
            LoadData();
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            cTextBoxIdBook.Texts = "";
            cTextBoxBookName.Texts = "";
            cTextBoxSellingPrice.Texts = "";
            cTextBoxDiscount.Texts = "";
            cTextBoxPriceAfterDiscount.Texts = "";
        }

        private void cBtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void cBtnAdd_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            AddBookDiscount fbook = new AddBookDiscount();
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
                fbook.d = new AddBookDiscount.Mydel(LoadDataBook);
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

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            if (cTextBoxBoxSearch.Texts != "")
            {
                LoadData(cTextBoxBoxSearch.Texts);
            }
            else
            {
                MessageBox.Show("Please enter a book name or author, v.v... to search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
            }
        }
    }
}
