using QLNS.BLL;
using QLNS.Views.ViewDashboard;
using QLNS.Views.ViewEntryBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Views.ViewEntryDiary
{
    public partial class DetailEntryBook : Form
    {
        int idStaff;
        DateTime dateEntry;
        public DetailEntryBook(int idStaff, DateTime dateEntry)
        {
            InitializeComponent();
            this.idStaff = idStaff;
            this.dateEntry = dateEntry;

            BLL_Book.Instance.SetList(dateEntry, idStaff);
        }

        private void btnCloseEditEntryDiary_Click(object sender, EventArgs e)
        {
            BLL_Book.Instance.ClearList();
            this.Close();
        }

        private void DetailEditEntryBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            cTextIdStaff.Texts = idStaff.ToString();
            cTextStaffName.Texts = BLL_User.Instance.GetStaffByID(idStaff).NameStaff;
            dateTimePickerEntry.Value = dateEntry;

            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Book.Instance.GetListBook(idStaff, dateEntry).Count == 0)
            {
                dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                dataGridViewBookOrder.Columns.Add("Quantity", "Quantity");
                dataGridViewBookOrder.Columns.Add("CostPrice", "Cost price(VND)");
            }
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Book.Instance.GetListBook(idStaff, dateEntry);
                dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Quantity";
                dataGridViewBookOrder.Columns[3].HeaderText = "Cost price(VND)";
            }

            lbTotalCost.Text = BLL_Book.Instance.GetTotalCost(idStaff, dateEntry).ToString();
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
    }
}
