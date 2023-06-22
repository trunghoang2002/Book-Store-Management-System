using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BLL
{
    public class BLL_Expense
    {
        private static BLL_Expense _Instance;
        public static BLL_Expense Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Expense();
                return _Instance;
            }
            private set { }
        }

        private BLL_Expense() { }

        public List<dynamic> GetListBookEntryDiaryFromDateToDate(DateTime date1, DateTime date2)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.DateEntry >= date1 && x.DateEntry <= date2).Select(x => new { x.ID_Book, x.Book.NameBook, x.Amount, TotalCost = x.Price * x.Amount, x.DateEntry, x.ID_Staff, x.Staff.NameStaff }).ToList<dynamic>();
            }
            return data;
        }

        public List<dynamic> GetListBookEntryDiaryFromDateToDateByBook(DateTime date1, DateTime date2)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.DateEntry >= date1 && x.DateEntry <= date2).GroupBy(x => new { x.ID_Book, x.Book.NameBook, x.Price }).Select(x => new { x.Key.ID_Book, x.Key.NameBook, TotalAmount = x.Sum(y => y.Amount), TotalCost = x.Key.Price * x.Sum(y => y.Amount) }).ToList<dynamic>();
            }
            return data;
        }

        public List<dynamic> GetListBookEntryDiaryFromDateToDateByCategory(DateTime date1, DateTime date2)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.DateEntry >= date1 && x.DateEntry <= date2).GroupBy(x => new { x.Book.ID_Category, x.Book.Category.NameCategory, x.Price }).Select(x => new { x.Key.ID_Category, x.Key.NameCategory, TotalAmount = x.Sum(y => y.Amount), TotalCost = x.Key.Price * x.Sum(y => y.Amount) }).ToList<dynamic>();
            }
            return data;
        }

        public int GetTotalPurcharedBook(List<dynamic> listBook)
        {
            int total = 0;
            foreach (dynamic i in listBook)
            {
                total += i.Amount;
            }
            return total;
        }

        public int GetTotalExpense(List<dynamic> listBook)
        {
            int total = 0;
            foreach (dynamic i in listBook)
            {
                total += i.TotalCost;
            }
            return total;
        }
    }
}
