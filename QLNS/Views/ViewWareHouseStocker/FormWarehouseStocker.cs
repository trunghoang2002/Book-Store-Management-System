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

namespace QLNS.Views.ViewWareHouseStocker
{
    public partial class FormWarehouseStocker : Form
    {
        public FormWarehouseStocker()
        {
            InitializeComponent();
            
            LoadDataAll();
            LoadLabel();
        }

        private void SetHeaderText()
        {
            dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
            dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
            dataGridViewBookOrder.Columns[2].HeaderText = "Total amount";
            dataGridViewBookOrder.Columns[3].HeaderText = "Remaining amount";
            dataGridViewBookOrder.Columns[4].HeaderText = "Sold amount";
        }

        private void AddColumns()
        {
            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
            dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
            dataGridViewBookOrder.Columns.Add("TotalAmount", "Total amount");
            dataGridViewBookOrder.Columns.Add("RemainingAmount", "Remaining amount");
            dataGridViewBookOrder.Columns.Add("SoldAmount", "Sold amount");
        }

        private void LoadDataAll()
        {
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListBookViewInStockByBook().Count > 0)
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBookViewInStockByBook();
                SetHeaderText();
            }
            else
            {
                MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddColumns();
            }
        }

        private void LoadDataRunningOut()
        {
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListBookViewRunningOut().Count > 0)
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBookViewRunningOut();
                SetHeaderText();
            }
            else
            {
                MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddColumns();
            }
        }
        
        private void LoadLabel()
        {
            lbTotalBPurchared.Text = BLL_Book.Instance.GetTotalBookPurchared().ToString();
            lbTotalBRemaining.Text = BLL_Book.Instance.GetTotalBookRemaining().ToString();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                LoadDataAll();
            }
        }

        private void rbRunningOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRunningOut.Checked)
            {
                LoadDataRunningOut();
            }
        }
    }
}
