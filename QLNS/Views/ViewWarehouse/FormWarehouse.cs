using QLNS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Views.ViewWarehouse
{
    public partial class FormWarehouse : Form
    {
        public FormWarehouse()
        {
            InitializeComponent();

            SetLabel();
            rbBook.Checked = true;
            LoadDataByBook();
        }

        private void SetLabel()
        {
            lbTotalBPurchared.Text = BLL_Book.Instance.GetTotalBookPurchared().ToString();
            lbTotalBRemaining.Text = BLL_Book.Instance.GetTotalBookRemaining().ToString();
        }

        private void LoadDataByBook()
        {
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListBookViewInStockByBook().Count > 0)
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBookViewInStockByBook();
                dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Total amount";
                dataGridViewBookOrder.Columns[3].HeaderText = "Remaining amount";
                dataGridViewBookOrder.Columns[4].HeaderText = "Sold amount";
            }   
            else
            {
                MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewBookOrder.DataSource = null;
                dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                dataGridViewBookOrder.Columns.Add("TotalAmount", "Total amount");
                dataGridViewBookOrder.Columns.Add("RemainingAmount", "Remaining amount");
                dataGridViewBookOrder.Columns.Add("SoldAmount", "Sold amount");
            }    
        }

        private void LoadDataByCategory()
        {
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListBookViewInStockByCategory().Count > 0)
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBookViewInStockByCategory();
                dataGridViewBookOrder.Columns[0].HeaderText = "Category's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Category's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Total amount";
                dataGridViewBookOrder.Columns[3].HeaderText = "Remaining amount";
                dataGridViewBookOrder.Columns[4].HeaderText = "Sold amount";
            }
            else
            {
                MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewBookOrder.DataSource = null;
                dataGridViewBookOrder.Columns.Add("IDCategory", "Category's ID");
                dataGridViewBookOrder.Columns.Add("NameCategory", "Category's name");
                dataGridViewBookOrder.Columns.Add("TotalAmount", "Total amount");
                dataGridViewBookOrder.Columns.Add("RemainingAmount", "Remaining amount");
                dataGridViewBookOrder.Columns.Add("SoldAmount", "Sold amount");
            }
        }

        private void rbCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCategory.Checked)
            {
                LoadDataByCategory();
            }
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                LoadDataByBook();
            }
        }
    }
}
