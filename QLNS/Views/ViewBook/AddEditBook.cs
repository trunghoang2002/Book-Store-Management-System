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
    public partial class AddEditBook : Form
    {
        public delegate void Mydel(string textSearch = "", int idCategory = 0);
        public Mydel d;
        int idBook;
        public AddEditBook(int idBook = 0)
        {
            InitializeComponent();
            this.idBook = idBook;

            SetCBBCategory();
            SetCBBPublish();
            LoadData();
        }

        private void SetCBBCategory()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.AddRange(BLL_Book.Instance.GetListCBBCategory().ToArray());
        }

        private void SetCBBPublish()
        {
            cbPublish.Items.Clear();
            cbPublish.Items.AddRange(BLL_Book.Instance.GetListCBBPublish().ToArray());
        }

        private void LoadData()
        {
            numericYearPublish.Maximum = DateTime.Now.Year;
            if (idBook != 0)
            {
                lbAddEditBook.Text = "Edit book";
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
                Book book = BLL_Book.Instance.GetBookByID(idBook);
                cTextBoxIdBook.Texts = book.ID_Book.ToString();
                cTextBoxBookName.Texts = book.NameBook;
                cTextBoxAuthorName.Texts = book.Author;
                foreach (CBBItem i in cbCategory.Items)
                {
                    if (i.Value == book.ID_Category)
                    {
                        cbCategory.SelectedItem = i;
                        break;
                    }    
                }    
                foreach (CBBItem i in cbPublish.Items)
                {
                    if (i.Value == book.ID_Publish)
                    {
                        cbPublish.SelectedItem = i;
                        break;
                    }    
                }    
                numericYearPublish.Value = book.YearPublish;
                numericEdition.Value = book.Edition;
                numericCostPrice.Value = book.CostPrice;
                numericSellingPrice.Value = book.SellingPrice;
            }
            else
            {
                cTextBoxIdBook.Texts = BLL_Book.Instance.GetIDNewBook().ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBtnSave_Click(object sender, EventArgs e)
        {
            if (cTextBoxBookName.Texts == "")
            {
                MessageBox.Show("Please enter book name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxBookName.Focus();
                return;
            }
            if (cTextBoxAuthorName.Texts == "")
            {
                MessageBox.Show("Please enter author name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cTextBoxAuthorName.Focus();
                return;
            }
            if (cbCategory.SelectedIndex == -1)
            {
                if (cbCategory.Text == "")
                {
                    MessageBox.Show("Please select an existing category or enter a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbCategory.Focus();
                    return;
                }
                else
                {
                    int idCate = BLL_Book.Instance.AddNewCategory(cbCategory.Text);
                    SetCBBCategory();
                    foreach (CBBItem i in cbCategory.Items)
                    {
                        if (i.Value == idCate)
                        {
                            cbCategory.SelectedItem = i;
                            break;
                        }
                    }
                }
            }
            if (cbPublish.SelectedIndex == -1)
            {
                if (cbPublish.Text == "")
                {
                    MessageBox.Show("Please select an existing publisher or enter a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbPublish.Focus();
                    return;
                }    
                else
                {
                    int idPub = BLL_Book.Instance.AddNewPublisher(cbPublish.Text);
                    SetCBBPublish();
                    foreach (CBBItem i in cbPublish.Items)
                    {
                        if (i.Value == idPub)
                        {
                            cbPublish.SelectedItem = i;
                            break;
                        }
                    }
                }
            }
            if (numericYearPublish.Value == 0)
            {
                MessageBox.Show("Please enter year publish", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericYearPublish.Focus();
                return;
            }
            if (numericSellingPrice.Value < numericCostPrice.Value)
            {
                MessageBox.Show("Selling price must be greater than or equal to cost price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericSellingPrice.Focus();
                return;
            }

            Book book = new Book
            {
                ID_Book = Convert.ToInt32(cTextBoxIdBook.Texts),
                NameBook = cTextBoxBookName.Texts,
                Author = cTextBoxAuthorName.Texts,
                ID_Category = ((CBBItem)cbCategory.SelectedItem).Value,
                ID_Publish = ((CBBItem)cbPublish.SelectedItem).Value,
                YearPublish = Convert.ToInt32(numericYearPublish.Value),
                Edition = Convert.ToInt32(numericEdition.Value),
                CostPrice = numericCostPrice.Value,
                SellingPrice = numericSellingPrice.Value
            };
            if (BLL_Book.Instance.GetBookByID(Convert.ToInt32(cTextBoxIdBook.Texts)) != null)
            {
                BLL_Book.Instance.UpdateBook(book);
            }
            else
            {
                BLL_Book.Instance.AddNewBook(book);
            }
            MessageBox.Show("Save successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            d();
            this.Close();
        }
    }
}
