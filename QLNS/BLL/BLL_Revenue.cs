using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BLL
{
    public class BLL_Revenue
    {
        private static BLL_Revenue _Instance;
        public static BLL_Revenue Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Revenue();
                return _Instance;
            }
            private set { }
        }
        
        private BLL_Revenue() { }

        public List<dynamic> GetListBookSoldByDate(DateTime date)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Detail_Bills.Where(x => x.IsDeleted == false && x.Bill.DatePay == date).Select(x => new { x.ID_Bill, x.ID_Book, x.Book.NameBook, x.Amount, x.Bill.DatePay, x.Price }).ToList<dynamic>();
            }
            return data;
        }
        
        public List<dynamic> GetListBookSoldFromDateToDate(DateTime date1, DateTime date2)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Detail_Bills.Where(x => x.IsDeleted == false && x.Bill.DatePay >= date1 && x.Bill.DatePay <= date2).Select(x => new { x.ID_Bill, x.ID_Book, x.Book.NameBook, x.Amount, x.Bill.DatePay, x.Price }).ToList<dynamic>();
            }
            return data;
        }

        public int GetTotalBookSold(List<dynamic> listBook)
        {
            int total = 0;
            foreach (dynamic i in listBook)
            {
                total += i.Amount;
            }
            return total;
        }

        public decimal GetTotalRevenue(List<dynamic> listBook)
        {
            decimal total = 0;
            foreach (dynamic i in listBook)
            {
                total += i.Amount * i.Price;
            }
            return total;
        }

        public List<dynamic> GetListBillFromDateToDate(DateTime date1, DateTime date2)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Bills.Where(x => x.IsDeleted == false && x.DatePay >= date1 && x.DatePay <= date2).Select(x => new { x.ID_Bill, x.NameCustomer, x.DatePay, x.TotalCost, x.ID_Staff , x.Staff.NameStaff, x.Payment.NamePayment }).ToList<dynamic>();
            }
            return data;
        }

        public List<dynamic> GetListBillFromDateToDateByBook(DateTime date1, DateTime date2)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Detail_Bills.Where(x => x.IsDeleted == false && x.Bill.DatePay >= date1 && x.Bill.DatePay <= date2).GroupBy(x => new { x.ID_Book, x.Book.NameBook }).Select(x => new { x.Key.ID_Book, x.Key.NameBook, TotalAmount = x.Sum(y => y.Amount), TotalPrice = x.Sum(y => y.Price) }).ToList<dynamic>();
            }
            return data;
        }

        public List<dynamic> GetListBillFromDateToDateByCategory(DateTime date1, DateTime date2)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Detail_Bills.Where(x => x.IsDeleted == false && x.Bill.DatePay >= date1 && x.Bill.DatePay <= date2).GroupBy(x => new { x.Book.ID_Category, x.Book.Category.NameCategory }).Select(x => new { x.Key.ID_Category, x.Key.NameCategory, TotalAmount = x.Sum(y => y.Amount), TotalPrice = x.Sum(y => y.Price) }).ToList<dynamic>();
            }
            return data;
        }

        public decimal GetTotalRevenueAdmin(DateTime date1, DateTime date2)
        {
            decimal total = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (db.Bills.Where(x => x.IsDeleted == false && x.DatePay >= date1 && x.DatePay <= date2).ToList().Count > 0)
                    total = db.Bills.Where(x => x.IsDeleted == false && x.DatePay >= date1 && x.DatePay <= date2).Sum(x => x.TotalCost);
            }
            return total;
        }

        public decimal GetTotalProfit(DateTime date1, DateTime date2)
        {
            decimal total = GetTotalRevenueAdmin(date1, date2);
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (db.Detail_Bills.Where(x => x.IsDeleted == false && x.Bill.DatePay >= date1 && x.Bill.DatePay <= date2).ToList().Count > 0)
                    total -= db.Detail_Bills.Where(x => x.IsDeleted == false && x.Bill.DatePay >= date1 && x.Bill.DatePay <= date2).Sum(x => x.Book.CostPrice * x.Amount);
            }
            return total;
        }
    }
}
