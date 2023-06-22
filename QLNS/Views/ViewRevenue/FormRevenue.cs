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

namespace QLNS.Views.ViewRevenue
{
    public partial class FormRevenue : Form
    {
        public FormRevenue()
        {
            InitializeComponent();
        }

        private void dateTimePickerRevenueOfDay_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerRevenueOfDay.Value.Date;
            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Revenue.Instance.GetListBookSoldByDate(date).Count == 0)
            {
                AddColumn();
            }
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Revenue.Instance.GetListBookSoldByDate(date);
                SetHeaderText();
            }    

            lbTotalBSold.Text = BLL_Revenue.Instance.GetTotalBookSold(BLL_Revenue.Instance.GetListBookSoldByDate(date)).ToString();
            lbTotalRevenue.Text = BLL_Revenue.Instance.GetTotalRevenue(BLL_Revenue.Instance.GetListBookSoldByDate(date)).ToString();
        }

        private void AddColumn()
        {
            dataGridViewBookOrder.Columns.Add("IDill", "Bill's ID");
            dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
            dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
            dataGridViewBookOrder.Columns.Add("Amount", "Amount");
            dataGridViewBookOrder.Columns.Add("Date", "Date");
            dataGridViewBookOrder.Columns.Add("Price", "Price(VND)");
        }

        private void SetHeaderText()
        {
            dataGridViewBookOrder.Columns[0].HeaderText = "Bill's ID";
            dataGridViewBookOrder.Columns[1].HeaderText = "Book's ID";
            dataGridViewBookOrder.Columns[2].HeaderText = "Book's name";
            dataGridViewBookOrder.Columns[3].HeaderText = "Amount";
            dataGridViewBookOrder.Columns[4].HeaderText = "Date";
            dataGridViewBookOrder.Columns[5].HeaderText = "Price(VND)";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show("Start date must be less than or equal to end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Value = dateTimePicker2.Value;
            }
            else
            {
                LoadData();
            }    
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show("End date must be greater than or equal to start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
            else
            {
                LoadData();
            }
        }
        
        private void LoadData()
        {
            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;
            if (BLL_Revenue.Instance.GetListBookSoldFromDateToDate(date1, date2).Count == 0)
            {
                AddColumn();
            }
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Revenue.Instance.GetListBookSoldFromDateToDate(date1, date2);
                SetHeaderText();
            }

            lbTotalBSold.Text = BLL_Revenue.Instance.GetTotalBookSold(BLL_Revenue.Instance.GetListBookSoldFromDateToDate(date1, date2)).ToString();
            lbTotalRevenue.Text = BLL_Revenue.Instance.GetTotalRevenue(BLL_Revenue.Instance.GetListBookSoldFromDateToDate(date1, date2)).ToString();
        }
    }
}
