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

namespace QLNS.Views.ViewExpense
{
    public partial class FormExpense : Form
    {
        public FormExpense()
        {
            InitializeComponent();
        }

        private void dateTimePickerFirst_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerSecond.Value.Date < dateTimePickerFirst.Value.Date)
            {
                MessageBox.Show("Start date must be less than or equal to end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerFirst.Value = dateTimePickerSecond.Value;
            }
            else
            {
                if (rbStocker.Checked) rbStocker_CheckedChanged(sender, e);
                if (rbBook.Checked) rbBook_CheckedChanged(sender, e);
                if (rbCategory.Checked) rbCategory_CheckedChanged(sender, e);
            }
        }

        private void dateTimePickerSecond_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerSecond.Value.Date < dateTimePickerFirst.Value.Date)
            {
                MessageBox.Show("End date must be greater than or equal to start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerSecond.Value = dateTimePickerFirst.Value;
            }
            else
            {
                if (rbStocker.Checked) rbStocker_CheckedChanged(sender, e);
                if (rbBook.Checked) rbBook_CheckedChanged(sender, e);
                if (rbCategory.Checked) rbCategory_CheckedChanged(sender, e);
            }    
        }

        private void rbStocker_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStocker.Checked)
            {
                dataGridViewBookOrder.DataSource = null;
                dataGridViewBookOrder.Columns.Clear();
                DateTime date1 = dateTimePickerFirst.Value.Date;
                DateTime date2 = dateTimePickerSecond.Value.Date;
                if (BLL_Expense.Instance.GetListBookEntryDiaryFromDateToDate(date1, date2).Count == 0)
                {
                    dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                    dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                    dataGridViewBookOrder.Columns.Add("Amount", "Amount");
                    dataGridViewBookOrder.Columns.Add("TotalCost", "Total cost");
                    dataGridViewBookOrder.Columns.Add("DateEntry", "Date entry");
                    dataGridViewBookOrder.Columns.Add("IDStaff", "Staff's ID");
                    dataGridViewBookOrder.Columns.Add("NameStaff", "Staff's name");
                }
                else
                {
                    dataGridViewBookOrder.DataSource = BLL_Expense.Instance.GetListBookEntryDiaryFromDateToDate(date1, date2);
                    dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
                    dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
                    dataGridViewBookOrder.Columns[2].HeaderText = "Amount";
                    dataGridViewBookOrder.Columns[3].HeaderText = "Total cost";
                    dataGridViewBookOrder.Columns[4].HeaderText = "Date entry";
                    dataGridViewBookOrder.Columns[5].HeaderText = "Staff's ID";
                    dataGridViewBookOrder.Columns[6].HeaderText = "Staff's name";
                }   
                
                LoadLabel(date1, date2);
            }    
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                dataGridViewBookOrder.DataSource = null;
                dataGridViewBookOrder.Columns.Clear();
                DateTime date1 = dateTimePickerFirst.Value.Date;
                DateTime date2 = dateTimePickerSecond.Value.Date;
                if (BLL_Expense.Instance.GetListBookEntryDiaryFromDateToDateByBook(date1, date2).Count == 0)
                {
                    dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                    dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                    dataGridViewBookOrder.Columns.Add("TotalAmount", "Total amount");
                    dataGridViewBookOrder.Columns.Add("TotalCost", "Total cost");
                }
                else
                {
                    dataGridViewBookOrder.DataSource = BLL_Expense.Instance.GetListBookEntryDiaryFromDateToDateByBook(date1, date2);
                    dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
                    dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
                    dataGridViewBookOrder.Columns[2].HeaderText = "Total amount";
                    dataGridViewBookOrder.Columns[3].HeaderText = "Total cost";
                }    

                LoadLabel(date1, date2);
            }    
        }

        private void rbCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCategory.Checked == true)
            {
                dataGridViewBookOrder.DataSource = null;
                dataGridViewBookOrder.Columns.Clear();
                DateTime date1 = dateTimePickerFirst.Value.Date;
                DateTime date2 = dateTimePickerSecond.Value.Date;
                if (BLL_Expense.Instance.GetListBookEntryDiaryFromDateToDateByCategory(date1, date2).Count == 0)
                {
                    dataGridViewBookOrder.Columns.Add("IDCategory", "Category's ID");
                    dataGridViewBookOrder.Columns.Add("NameCategory", "Category's name");
                    dataGridViewBookOrder.Columns.Add("TotalAmount", "Total amount");
                    dataGridViewBookOrder.Columns.Add("TotalCost", "Total cost");
                }
                else
                {
                    dataGridViewBookOrder.DataSource = BLL_Expense.Instance.GetListBookEntryDiaryFromDateToDateByCategory(date1, date2);
                    dataGridViewBookOrder.Columns[0].HeaderText = "Category's ID";
                    dataGridViewBookOrder.Columns[1].HeaderText = "Category's name";
                    dataGridViewBookOrder.Columns[2].HeaderText = "Total amount";
                    dataGridViewBookOrder.Columns[3].HeaderText = "Total cost";
                }    

                LoadLabel(date1, date2);
            }    
        }
        
        private void LoadLabel(DateTime date1, DateTime date2)
        {
            lbTotalPurcharedBook.Text = BLL_Expense.Instance.GetTotalPurcharedBook(BLL_Expense.Instance.GetListBookEntryDiaryFromDateToDate(date1, date2)).ToString();
            lbTotalExpense.Text = BLL_Expense.Instance.GetTotalExpense(BLL_Expense.Instance.GetListBookEntryDiaryFromDateToDate(date1, date2)).ToString();
        }
    }
}
