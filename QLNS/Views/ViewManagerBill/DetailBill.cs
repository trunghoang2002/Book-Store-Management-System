using QLNS.BLL;
using QLNS.DTO;
using QLNS.Views.ViewBill;
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

namespace QLNS.Views.ViewManagerBill
{
    public partial class DetailBill : Form
    {
        int idBill;
        public DetailBill(int idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
            
            BLL_Bill.Instance.SetList(idBill);
        }

        private void DetailEditBill_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            cTextCustomerName.Texts = BLL_Bill.Instance.GetBillByID(idBill).NameCustomer;

            cTextIdBill.Texts = idBill.ToString();
            dateTimePickerOrder.Value = BLL_Bill.Instance.GetBillByID(idBill).DatePay;
            cTextIdStaff.Texts = BLL_Bill.Instance.GetBillByID(idBill).ID_Staff.ToString();

            dataGridViewBookOrder.DataSource = null;
            dataGridViewBookOrder.Columns.Clear();
            if (BLL_Bill.Instance.GetListBookInOldBill(idBill).Count == 0)
            {
                dataGridViewBookOrder.Columns.Add("IDBook", "Book's ID");
                dataGridViewBookOrder.Columns.Add("NameBook", "Book's name");
                dataGridViewBookOrder.Columns.Add("Author", "Author");
                dataGridViewBookOrder.Columns.Add("Category", "Category");
                dataGridViewBookOrder.Columns.Add("Publisher", "Publisher");
                dataGridViewBookOrder.Columns.Add("PublishingYear", "Publishing year");
                dataGridViewBookOrder.Columns.Add("Edition", "Edition");
                dataGridViewBookOrder.Columns.Add("Quantity", "Quantity");
                dataGridViewBookOrder.Columns.Add("Price", "price(VND)");
            }
            else
            {
                dataGridViewBookOrder.DataSource = BLL_Bill.Instance.GetListBookInOldBill(idBill);
                dataGridViewBookOrder.Columns[0].HeaderText = "Book's ID";
                dataGridViewBookOrder.Columns[1].HeaderText = "Book's name";
                dataGridViewBookOrder.Columns[2].HeaderText = "Author";
                dataGridViewBookOrder.Columns[3].HeaderText = "Category";
                dataGridViewBookOrder.Columns[4].HeaderText = "Publisher";
                dataGridViewBookOrder.Columns[5].HeaderText = "Publishing year";
                dataGridViewBookOrder.Columns[6].HeaderText = "Edition";
                dataGridViewBookOrder.Columns[7].HeaderText = "Quantity";
                dataGridViewBookOrder.Columns[8].HeaderText = "Price(VND)";
            }    
            
            lbTotalAmount.Text = BLL_Bill.Instance.GetTotalCostOldBill(idBill).ToString();
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

        private void btnCloseEditBill_Click(object sender, EventArgs e)
        {
            BLL_Bill.Instance.ClearList();
            this.Close();
        }
    }
}
