using QLNS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using Aspose.Words.Tables;
using QLNS.Lib;

namespace QLNS.BLL
{
    public class BLL_Bill
    {
        List<KeyValuePair<int, int>> list_book_quantity = new List<KeyValuePair<int, int>>(); // lưu thông tin sách và số lượng mua(tạm thời, chưa save vào csdl)

        private static BLL_Bill _Instance;
        public static BLL_Bill Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Bill();
                return _Instance;
            }
            private set { }
        }

        private BLL_Bill() { }

        public List<dynamic> GetListBillView(string name = "")
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Bills.Where(x => x.NameCustomer.Contains(name) && x.IsDeleted == false).Select(x => new { x.ID_Bill, x.ID_Staff, x.NameCustomer, x.DatePay, x.Payment.NamePayment, x.TotalCost }).ToList<dynamic>();
            }
            return data;
        }

        public int GetIDNewBill()
        {
            int id = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                id = db.Bills.Max(x => x.ID_Bill) + 1;
            }
            return id;
        }

        public void DeleteBill(int idBill)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Bill bill = db.Bills.Find(idBill);
                bill.IsDeleted = true;
                foreach (Detail_Bill i in db.Detail_Bills.Where(x => x.ID_Bill == idBill))
                {
                    i.IsDeleted = true;
                }
                db.SaveChanges();
            }
        }

        public Bill GetBillByID(int id)
        {
            Bill data = new Bill();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Bills.Where(x => x.ID_Bill == id).FirstOrDefault();
            }
            return data;
        }

        public List<dynamic> GetListDetailByID(int id)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Detail_Bills.Where(x => x.IsDeleted == false && x.ID_Bill == id).Select(x => new { x.ID_Book, x.Amount }).ToList<dynamic>();
            }
            return data;
        }

        public List<CBBItem> GetListCBBPayment()
        {
            List<CBBItem> data = new List<CBBItem>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Payments.Where(x => x.IsDeleted == false).Select(x => new CBBItem { Value = x.ID_Payment, Text = x.NamePayment }).ToList();
            }
            return data;
        }

        public void CheckBookAmount(int idBook, int amount)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Book book = db.Books.Find(idBook);
                if (book.Book_Warehouse.RemainingAmount < amount)
                {
                    throw new Exception("The number of this book in stock is not enough");
                }
            }
        }

        public bool CheckBookInBill(int id_book)
        {
            foreach (KeyValuePair<int, int> i in list_book_quantity)
            {
                if (i.Key == id_book)
                    return true;
            }
            return false;
        }

        public void AddBookToBill(int bookID, int quantity)
        {
            if (CheckBookInBill(bookID))
            {
                foreach (KeyValuePair<int, int> i in list_book_quantity)
                {
                    if (i.Key == bookID)
                    {
                        int oldquantity = i.Value;
                        list_book_quantity.Remove(i);
                        list_book_quantity.Add(new KeyValuePair<int, int>(bookID, oldquantity + quantity));
                        SetRemainAmountDB(bookID, quantity);
                        break;
                    }
                }
            }
            else
            {
                list_book_quantity.Add(new KeyValuePair<int, int>(bookID, quantity));
                SetRemainAmountDB(bookID, quantity);
            }
        }

        // set remain amount tạm thời
        public void SetRemainAmountDB(int id_book, int quantity)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Book_Warehouse book_warehouse = db.Book_Warehouses.Find(id_book);
                book_warehouse.RemainingAmount -= quantity;
                db.SaveChanges();
            }
        }

        // trả lại remain amount ban đầu và clear list tạm thời
        public void ReturnRemainAmountDB()
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                foreach (KeyValuePair<int, int> i in list_book_quantity)
                {
                    Book_Warehouse book_warehouse = db.Book_Warehouses.Find(i.Key);
                    book_warehouse.RemainingAmount += i.Value;
                }
                db.SaveChanges();
            }
            ClearList();
        }

        public void ClearList()
        {
            list_book_quantity.Clear();
        }

        // lưu lại trạng thái của bill hiện tại
        public void SetList(int idBill)
        {
            List<dynamic> data = GetListDetailByID(idBill);
            foreach (dynamic i in data)
            {
                list_book_quantity.Add(new KeyValuePair<int, int>(i.ID_Book, i.Amount)); // list này để thao tác thêm sửa xóa
            }
        }

        public List<dynamic> GetListBookInNewBill()
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                foreach (KeyValuePair<int, int> i in list_book_quantity)
                {
                    Book book = db.Books.Where(x => x.ID_Book == i.Key).FirstOrDefault();
                    data.Add(new
                    {
                        ID_Book = i.Key,
                        Name_Book = book.NameBook,
                        Author = book.Author,
                        NameCategory = book.Category.NameCategory,
                        NamePublisher = book.Publish.NamePublisher,
                        YearPublish = book.YearPublish,
                        Edition = book.Edition,
                        Quantity = i.Value,
                        SellingPrice = book.SellingPrice,
                        Discount = book.Book_Discount.Discount,
                        RealPrice = book.SellingPrice * (1 - book.Book_Discount.Discount / 100)
                    });
                }
            }
            return data;
        }

        public List<dynamic> GetListBookInOldBill(int idBill)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                foreach (KeyValuePair<int, int> i in list_book_quantity)
                {
                    Book book = db.Books.Where(x => x.ID_Book == i.Key).FirstOrDefault();
                    decimal price = book.SellingPrice * (1 - book.Book_Discount.Discount / 100);
                    if (book.Detail_Bills.Where(x => x.ID_Bill == idBill && x.ID_Book == i.Key).FirstOrDefault() != null)
                        price = book.Detail_Bills.Where(x => x.ID_Bill == idBill && x.ID_Book == i.Key).FirstOrDefault().Price;
                    data.Add(new
                    {
                        ID_Book = i.Key,
                        Name_Book = book.NameBook,
                        Author = book.Author,
                        NameCategory = book.Category.NameCategory,
                        NamePublisher = book.Publish.NamePublisher,
                        YearPublish = book.YearPublish,
                        Edition = book.Edition,
                        Quantity = i.Value,
                        Price = price,
                    });
                }
            }
            return data;
        }

        public void RemoveBookInBill(int idBook)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                foreach (KeyValuePair<int, int> i in list_book_quantity)
                {
                    if (i.Key == idBook)
                    {
                        Book_Warehouse book_warehouse = db.Book_Warehouses.Find(i.Key);
                        book_warehouse.RemainingAmount += i.Value;
                        list_book_quantity.Remove(i);
                        break;
                    }
                }
                db.SaveChanges();
            }
        }

        public decimal GetTotalCostNewBill()
        {
            decimal total = 0;
            foreach (dynamic i in GetListBookInNewBill())
            {
                total += i.RealPrice * i.Quantity;
            }
            return total;
        }

        public decimal GetTotalCostOldBill(int idBill)
        {
            decimal total = 0;
            foreach (dynamic i in GetListBookInOldBill(idBill))
            {
                total += i.Price * i.Quantity;
            }
            return total;
        }
        
        public void AddNewBill(Bill bill)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                db.Bills.Add(bill);
                db.SaveChanges();
            }
        }

        public void AddNewDetailBill(Detail_Bill detailBill)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                db.Detail_Bills.Add(detailBill);
                db.SaveChanges();
            }
        }

        public void PrintBill(Bill bill)
        {
            // Nạp file mẫu
            string directory = System.IO.Directory.GetCurrentDirectory();
            string file = directory.Replace(@"bin\Debug", @"TemplateBill\TemplateBill.doc");
            Document document = new Document(file);

            // Điền các thông tin cố định
            document.MailMerge.Execute(new[] { "ID_Bill" }, new[] { bill.ID_Bill.ToString() });
            string date = bill.DatePay.ToString("dd/MM/yyyy");
            document.MailMerge.Execute(new[] { "DatePay" }, new[] { date });
            document.MailMerge.Execute(new[] { "CustomerName" }, new[] { bill.NameCustomer });
            decimal subtotal = 0;
            foreach (dynamic i in GetListBookInNewBill())
            {
                subtotal += i.SellingPrice * i.Quantity;
            }
            document.MailMerge.Execute(new[] { "Subtotal" }, new[] { subtotal.ToString() });
            decimal discountTotal = 0;
            foreach (dynamic i in GetListBookInNewBill())
            {
                discountTotal += (i.SellingPrice - i.RealPrice) * i.Quantity;
            }
            document.MailMerge.Execute(new[] { "DiscountTotal" }, new[] { discountTotal.ToString() });
            document.MailMerge.Execute(new[] { "InvoiceTotal" }, new[] { bill.TotalCost.ToString() });

            // Điền thông tin lên bảng
            Table detailBill = document.GetChild(NodeType.Table, 1, true) as Table;
            int currentRow = 2;
            int rowCount = GetListBookInNewBill().Count;
            detailBill.InsertRows(currentRow, currentRow, 2 * rowCount - 2); // đã có sẵn 1 row
            foreach (dynamic i in GetListBookInNewBill())
            {
                string nameBook = i.Name_Book;
                int quantity = i.Quantity;
                decimal sellPrice = i.SellingPrice;
                decimal discount = i.Discount;
                decimal realPrice = i.RealPrice;
                detailBill.PutValue(currentRow, 0, nameBook); // col 1
                detailBill.PutValue(currentRow, 1, quantity.ToString()); // col 2
                detailBill.PutValue(currentRow, 2, sellPrice.ToString()); // col 3
                detailBill.PutValue(currentRow, 3, discount.ToString()); // col 4
                detailBill.PutValue(currentRow, 4, realPrice.ToString()); // col 5
                currentRow += 2;
            }    

            // Lưu và mở file
            document.SaveAndOpenFile("Bill.doc");
        }
    }
}