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

namespace QLNS.Views.ViewBook
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
            
            SetCBBCategory();
            SetCBBSort();
            LoadData();
        }

        private void SetCBBCategory()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add(new CBBItem { Text = "All", Value = 0 });
            cbCategory.Items.AddRange(BLL_Book.Instance.GetListCBBCategory().ToArray());
            cbCategory.SelectedIndex = 0;
        }

        private void SetCBBSort()
        {
            cbSort.Items.Clear();
            cbSort.Items.AddRange(new string[] { "ID", "Name", "Author", "Publisher", "Publishing year", "Remaining amount", "Cost price", "Selling price", "Discount" });
        }

        private void LoadData(string textSearch = "", int idCategory = 0)
        {
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListBookView(textSearch, idCategory).Count > 0)
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBookViewAdmin(textSearch, idCategory);
            }
            else
            {
                MessageBox.Show("No book found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCategory.SelectedIndex = 0;
                if (BLL_Book.Instance.GetListBookViewAdmin("", 0).Count == 0)
                {
                    dataGridViewBookOrder.DataSource = null;
                    dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                    dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                    dataGridViewBookOrder.Columns.Add("Author", "Author");
                    dataGridViewBookOrder.Columns.Add("Category", "Category");
                    dataGridViewBookOrder.Columns.Add("Publisher", "Publisher");
                    dataGridViewBookOrder.Columns.Add("PublishingYear", "Publishing year");
                    dataGridViewBookOrder.Columns.Add("Edition", "Edition");
                    dataGridViewBookOrder.Columns.Add("RemainingAmount", "Remaining amount");
                    dataGridViewBookOrder.Columns.Add("CostPrice", "Cost price(VND)");
                    dataGridViewBookOrder.Columns.Add("SellingPrice", "Selling price(VND)");
                    dataGridViewBookOrder.Columns.Add("Discount", "Discount(%)");
                    return;
                }   
                else
                {
                    dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBookViewAdmin("", 0);
                }    
            }
            dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
            dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
            dataGridViewBookOrder.Columns[2].HeaderText = "Author";
            dataGridViewBookOrder.Columns[3].HeaderText = "Category";
            dataGridViewBookOrder.Columns[4].HeaderText = "Publisher";
            dataGridViewBookOrder.Columns[5].HeaderText = "Publishing year";
            dataGridViewBookOrder.Columns[6].HeaderText = "Edition";
            dataGridViewBookOrder.Columns[7].HeaderText = "Remaining amount";
            dataGridViewBookOrder.Columns[8].HeaderText = "Cost price(VND)";
            dataGridViewBookOrder.Columns[9].HeaderText = "Selling price(VND)";
            dataGridViewBookOrder.Columns[10].HeaderText = "Discount(%)";
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookOrder.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete those books?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewBookOrder.SelectedRows)
                    {
                        int idBook = Convert.ToInt32(row.Cells["ID_Book"].Value);
                        BLL_Book.Instance.DeleteBook(idBook);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            AddEditBook fbook = new AddEditBook();
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
                fbook.d = new AddEditBook.Mydel(LoadData);
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
            SetCBBCategory();
        }

        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookOrder.SelectedRows.Count == 1)
            {
                int idBook = Convert.ToInt32(dataGridViewBookOrder.SelectedRows[0].Cells["ID_Book"].Value);
                Form formBackground = new Form();
                AddEditBook fbook = new AddEditBook(idBook);
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
                    fbook.d = new AddEditBook.Mydel(LoadData);
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
                SetCBBCategory();
            }
            else
            {
                MessageBox.Show("Please select only one row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void iBtnSort_Click(object sender, EventArgs e)
        {
            List<dynamic> data = BLL_Book.Instance.GetListBookViewAdmin(cTextBoxSearch.Texts, ((CBBItem)cbCategory.SelectedItem).Value);
            if (cbSort.SelectedItem != null)
            {
                string sort = cbSort.SelectedItem.ToString();
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.SortListBookView(data, sort);
            }
        }
    }
}
