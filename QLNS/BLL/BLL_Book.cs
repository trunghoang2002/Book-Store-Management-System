using QLNS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BLL
{
    public class BLL_Book
    {
        List<KeyValuePair<int, int>> list_book_quantity = new List<KeyValuePair<int, int>>(); // sử dụng cho bookentry

        private static BLL_Book _Instance;
        public static BLL_Book Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Book();
                return _Instance;
            }
            private set { }
        }

        private BLL_Book() { }

        public int GetIDNewBook()
        {
            int id = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                id = db.Books.Max(x => x.ID_Book) + 1;
            }
            return id;
        }

        public List<dynamic> GetListBookView(string textSearch = "", int idCategory = 0)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (idCategory == 0)
                    data = db.Books.Where(x => x.IsDeleted == false && (x.NameBook.Contains(textSearch) || x.Author.Contains(textSearch) || x.Publish.NamePublisher.Contains(textSearch)))
                        .Select(x => new { x.ID_Book, x.NameBook, x.Author, x.Category.NameCategory, x.Publish.NamePublisher, x.YearPublish, x.Edition, x.Book_Warehouse.RemainingAmount, x.SellingPrice, x.Book_Discount.Discount, RealPrice = x.SellingPrice * (1 - x.Book_Discount.Discount / 100) }).ToList<dynamic>();
                else
                    data = db.Books.Where(x => x.IsDeleted == false && x.ID_Category == idCategory && (x.NameBook.Contains(textSearch) || x.Author.Contains(textSearch) || x.Publish.NamePublisher.Contains(textSearch)))
                    .Select(x => new { x.ID_Book, x.NameBook, x.Author, x.Category.NameCategory, x.Publish.NamePublisher, x.YearPublish, x.Edition, x.Book_Warehouse.RemainingAmount, x.SellingPrice, x.Book_Discount.Discount, RealPrice = x.SellingPrice * (1 - x.Book_Discount.Discount / 100) }).ToList<dynamic>();
            }
            return data;
        }

        public List<dynamic> GetListBookViewAdmin(string textSearch = "", int idCategory = 0)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (idCategory == 0)
                    data = db.Books.Where(x => x.IsDeleted == false && (x.NameBook.Contains(textSearch) || x.Author.Contains(textSearch) || x.Publish.NamePublisher.Contains(textSearch)))
                        .Select(x => new { x.ID_Book, x.NameBook, x.Author, x.Category.NameCategory, x.Publish.NamePublisher, x.YearPublish, x.Edition, x.Book_Warehouse.RemainingAmount, x.CostPrice, x.SellingPrice, x.Book_Discount.Discount }).ToList<dynamic>();
                else
                    data = db.Books.Where(x => x.IsDeleted == false && x.ID_Category == idCategory && (x.NameBook.Contains(textSearch) || x.Author.Contains(textSearch) || x.Publish.NamePublisher.Contains(textSearch)))
                        .Select(x => new { x.ID_Book, x.NameBook, x.Author, x.Category.NameCategory, x.Publish.NamePublisher, x.YearPublish, x.Edition, x.Book_Warehouse.RemainingAmount, x.CostPrice, x.SellingPrice, x.Book_Discount.Discount }).ToList<dynamic>();
            }
            return data;
        }

        public List<dynamic> GetListBookViewInStockByBook()
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Books.Where(x => x.IsDeleted == false).Select(x => new { x.ID_Book, x.NameBook, x.Book_Warehouse.TotalAmount, x.Book_Warehouse.RemainingAmount, SoldAmount = x.Book_Warehouse.TotalAmount - x.Book_Warehouse.RemainingAmount }).ToList<dynamic>();
            }
            return data;
        }

        public List<dynamic> GetListBookViewRunningOut()
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Books.Where(x => x.IsDeleted == false && x.Book_Warehouse.RemainingAmount <= 50).Select(x => new { x.ID_Book, x.NameBook, x.Book_Warehouse.TotalAmount, x.Book_Warehouse.RemainingAmount, SoldAmount = x.Book_Warehouse.TotalAmount - x.Book_Warehouse.RemainingAmount }).ToList<dynamic>();
            }
            return data;
        }

        public List<dynamic> GetListBookViewInStockByCategory()
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Books.Where(x => x.IsDeleted == false).GroupBy(x => new { x.ID_Category, x.Category.NameCategory }).Select(x => new { x.Key.ID_Category, x.Key.NameCategory, TotalAmount = x.Sum(y => y.Book_Warehouse.TotalAmount), RemainingAmount = x.Sum(y => y.Book_Warehouse.RemainingAmount), SoldAmount = x.Sum(y => y.Book_Warehouse.TotalAmount) - x.Sum(y => y.Book_Warehouse.RemainingAmount) }).ToList<dynamic>();
                foreach (Category i in db.Categories)
                {
                    if (data.Where(x => x.ID_Category == i.ID_Category).Count() == 0)
                    {
                        data.Add(new { ID_Category = i.ID_Category, NameCategory = i.NameCategory, TotalAmount = 0, RemainingAmount = 0, SoldAmount = 0 });
                    }
                }
                data = data.OrderBy(x => x.ID_Category).ToList();
            }
            return data;
        }

        public int GetTotalBookPurchared()
        {
            int total = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                total = db.Books.Where(x => x.IsDeleted == false).Sum(x => x.Book_Warehouse.TotalAmount);
            }
            return total;
        }

        public int GetTotalBookRemaining()
        {
            int total = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                total = db.Books.Where(x => x.IsDeleted == false).Sum(x => x.Book_Warehouse.RemainingAmount);
            }
            return total;
        }

        public List<dynamic> GetListBookViewDiscount(string textSearch = "")
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Books.Where(x => x.IsDeleted == false && x.Book_Discount.Discount > 0 && (x.NameBook.Contains(textSearch) || x.Author.Contains(textSearch) || x.Category.NameCategory.Contains(textSearch) || x.Publish.NamePublisher.Contains(textSearch)))
                    .Select(x => new { x.ID_Book, x.NameBook, x.Author, x.Category.NameCategory, x.Publish.NamePublisher, x.YearPublish, x.Edition, x.CostPrice, x.SellingPrice, x.Book_Discount.Discount, RealPrice = x.SellingPrice * (1 - x.Book_Discount.Discount / 100) }).ToList<dynamic>();
            }
            return data;
        }

        public Book GetBookByID(int id)
        {
            Book data = new Book();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Books.Find(id);
            }
            return data;
        }

        public Book_Discount GetDiscountByID(int id)
        {
            Book_Discount data = new Book_Discount();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Book_Discounts.Find(id);
            }
            return data;
        }

        public List<CBBItem> GetListCBBCategory()
        {
            List<CBBItem> data = new List<CBBItem>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Categories.Where(x => x.IsDeleted == false).Select(x => new CBBItem { Value = x.ID_Category, Text = x.NameCategory }).ToList();
            }
            return data;
        }

        public List<CBBItem> GetListCBBPublish()
        {
            List<CBBItem> data = new List<CBBItem>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Publishes.Where(x => x.IsDeleted == false).Select(x => new CBBItem { Value = x.ID_Publish, Text = x.NamePublisher }).ToList();
            }
            return data;
        }

        public int AddNewCategory(string nameCategory)
        {
            int idCate;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                idCate = db.Categories.Count() + 1;
                db.Categories.Add(new Category
                {
                    ID_Category = db.Categories.Count() + 1,
                    NameCategory = nameCategory
                });
                db.SaveChanges();
            }
            return idCate;
        }

        public int AddNewPublisher(string namePublisher)
        {
            int idPub;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                idPub = db.Publishes.Count() + 1;
                db.Publishes.Add(new Publish
                {
                    ID_Publish = db.Publishes.Count() + 1,
                    NamePublisher = namePublisher
                });
                db.SaveChanges();
            }
            return idPub;
        }

        public void AddNewBook(Book book)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                db.Books.Add(book);
                db.Book_Warehouses.Add(new Book_Warehouse
                {
                    ID_Book_Warehouse = book.ID_Book,
                    TotalAmount = 0,
                    RemainingAmount = 0
                });
                db.Book_Discounts.Add(new Book_Discount
                {
                    ID_Book_Discount = book.ID_Book,
                    Discount = 0
                });
                db.SaveChanges();
            }
        }

        public void UpdateBook(Book book)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Book b = db.Books.Find(book.ID_Book);
                b.NameBook = book.NameBook;
                b.Author = book.Author;
                b.ID_Category = book.ID_Category;
                b.ID_Publish = book.ID_Publish;
                b.YearPublish = book.YearPublish;
                b.Edition = book.Edition;
                b.CostPrice = book.CostPrice;
                b.SellingPrice = book.SellingPrice;
                db.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Book_Discount discount = db.Book_Discounts.Find(id);
                discount.IsDeleted = true;
                Book_Warehouse book_Warehouse = db.Book_Warehouses.Find(id);
                book_Warehouse.IsDeleted = true;
                Book book = db.Books.Find(id);
                book.IsDeleted = true;
                db.SaveChanges();
            }
        }

        public void AddNewDiscount(int idBook, decimal discount)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                db.Book_Discounts.Add(new Book_Discount
                {
                    ID_Book_Discount = idBook,
                    Discount = discount
                });
                db.SaveChanges();
            }
        }

        public void UpdateDiscount(int idBook, decimal discount)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Book_Discount discountBook = db.Book_Discounts.Find(idBook);
                discountBook.Discount = discount;
                db.SaveChanges();
            }
        }

        public void DeleteDiscount(int idBook)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Book_Discount discountBook = db.Book_Discounts.Find(idBook);
                discountBook.Discount = 0;
                db.SaveChanges();
            }
        }

        public bool CheckDiscountExist(int idBook)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (db.Book_Discounts.Find(idBook) != null)
                {
                    return true;
                }
                else return false;
            }
        }

        public List<dynamic> GetListBook(int idStaff, DateTime date)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                foreach (KeyValuePair<int, int> i in list_book_quantity)
                {
                    Book book = db.Books.Where(x => x.ID_Book == i.Key).FirstOrDefault();
                    decimal price = book.CostPrice;
                    if (db.Book_Entry_Diarys.Where(x => x.ID_Book == i.Key && x.ID_Staff == idStaff && x.DateEntry == date).FirstOrDefault() != null)
                    {
                        price = db.Book_Entry_Diarys.Where(x => x.ID_Book == i.Key && x.ID_Staff == idStaff && x.DateEntry == date).FirstOrDefault().Price;
                    }
                    data.Add(new
                    {
                        ID_Book = i.Key,
                        Name_Book = book.NameBook,
                        Quantity = i.Value,
                        CostPrice = price
                    });
                }
            }
            return data;
        }

        public bool CheckBookInList(int idBook)
        {
            foreach (KeyValuePair<int, int> i in list_book_quantity)
            {
                if (i.Key == idBook)
                    return true;
            }
            return false;
        }

        public void AddBookToList(int idBook, int quantity)
        {
            if (CheckBookInList(idBook))
            {
                foreach (KeyValuePair<int, int> i in list_book_quantity)
                {
                    if (i.Key == idBook)
                    {
                        int oldquantity = i.Value;
                        list_book_quantity.Remove(i);
                        list_book_quantity.Add(new KeyValuePair<int, int>(idBook, oldquantity + quantity));
                        break;
                    }
                }
            }
            else
            {
                list_book_quantity.Add(new KeyValuePair<int, int>(idBook, quantity));
            }
        }

        public void RemoveBookFromList(int idBook)
        {
            foreach (KeyValuePair<int, int> i in list_book_quantity)
            {
                if (i.Key == idBook)
                {
                    list_book_quantity.Remove(i);
                    break;
                }
            }
        }

        public void ClearList()
        {
            list_book_quantity.Clear();
        }

        public void AddListBookToWarehouse(int idStaff, DateTime date)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                foreach (KeyValuePair<int, int> i in list_book_quantity)
                {
                    Book_Entry_Diary book_Entry_Diary = db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.ID_Book == i.Key && x.DateEntry == date && x.ID_Staff == idStaff).FirstOrDefault();
                    if (book_Entry_Diary == null)
                    {
                        db.Book_Entry_Diarys.Add(new Book_Entry_Diary
                        {
                            ID_Book = i.Key,
                            Amount = i.Value,
                            Price = db.Books.Where(x => x.ID_Book == i.Key).FirstOrDefault().CostPrice,
                            DateEntry = date,
                            ID_Staff = idStaff
                        });
                    }
                    else
                    {
                        book_Entry_Diary.Amount += i.Value;
                    }
                    Book_Warehouse book_Warehouse = db.Book_Warehouses.Where(x => x.IsDeleted == false && x.ID_Book_Warehouse == i.Key).FirstOrDefault();
                    book_Warehouse.TotalAmount += i.Value;
                    book_Warehouse.RemainingAmount += i.Value;
                }
                db.SaveChanges();
            }
        }

        public List<dynamic> GetListEntryDiary(DateTime date1, DateTime date2, string nameStaff)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.Staff.NameStaff.Contains(nameStaff) && x.DateEntry >= date1 && x.DateEntry <= date2).GroupBy(x => new { x.ID_Staff, x.Staff.NameStaff, x.DateEntry }).Select(x => new { x.Key.ID_Staff, x.Key.NameStaff, x.Key.DateEntry, TotalAmount = x.Sum(y => y.Amount), TotalCost = x.Sum(y => y.Price * y.Amount) }).ToList<dynamic>();
            }
            return data;
        }

        public int GetTotalAmount(DateTime date1, DateTime date2, string nameStaff)
        {
            int total = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.Staff.NameStaff.Contains(nameStaff) && x.DateEntry >= date1 && x.DateEntry <= date2).ToList().Count > 0)
                    total = db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.Staff.NameStaff.Contains(nameStaff) && x.DateEntry >= date1 && x.DateEntry <= date2).Sum(x => x.Amount);
            }
            return total;
        }

        public decimal GetTotalExpense(DateTime date1, DateTime date2, string nameStaff)
        {
            decimal total = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.Staff.NameStaff.Contains(nameStaff) && x.DateEntry >= date1 && x.DateEntry <= date2).ToList().Count > 0)
                    total = db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.Staff.NameStaff.Contains(nameStaff) && x.DateEntry >= date1 && x.DateEntry <= date2).Sum(x => x.Price * x.Amount);
            }
            return total;
        }

        public void DeleteEntryDiary(int idStaff, DateTime dateEntry)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                foreach (Book_Entry_Diary i in db.Book_Entry_Diarys.Where(x => x.ID_Staff == idStaff && x.DateEntry == dateEntry))
                {
                    i.IsDeleted = true;
                }
                db.SaveChanges();
            }
        }

        public List<dynamic> GetListDetailEntry(DateTime dateEntry, int idStaff)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Book_Entry_Diarys.Where(x => x.IsDeleted == false && x.ID_Staff == idStaff && x.DateEntry == dateEntry).ToList<dynamic>();
            }
            return data;
        }

        public void SetList(DateTime dateEntry, int idStaff)
        {
            List<dynamic> data = GetListDetailEntry(dateEntry, idStaff);
            foreach (dynamic i in data)
            {
                list_book_quantity.Add(new KeyValuePair<int, int>(i.ID_Book, i.Amount));
            }
        }

        public decimal GetTotalCost(int idStaff, DateTime date)
        {
            decimal total = 0;
            foreach (dynamic i in GetListBook(idStaff, date))
            {
                total += i.Quantity * i.CostPrice;
            }
            return total;
        }

        public delegate bool Compare(dynamic d1, dynamic d2);

        public bool CompareIDBook(dynamic d1, dynamic d2)
        {
            return d1.ID_Book > d2.ID_Book;
        }

        public bool CompareNameBook(dynamic d1, dynamic d2)
        {
            return string.Compare(d1.NameBook, d2.NameBook) > 0;
        }

        public bool CompareAuthor(dynamic d1, dynamic d2)
        {
            return string.Compare(d1.Author, d2.Author) > 0;
        }

        public bool CompareNamePublisher(dynamic d1, dynamic d2)
        {
            return string.Compare(d1.NamePublisher, d2.NamePublisher) > 0;
        }

        public bool CompareYearPublish(dynamic d1, dynamic d2)
        {
            return d1.YearPublish > d2.YearPublish;
        }

        public bool CompareRemainingAmount(dynamic d1, dynamic d2)
        {
            return d1.RemainingAmount > d2.RemainingAmount;
        }

        public bool CompareCostPrice(dynamic d1, dynamic d2)
        {
            return d1.CostPrice > d2.CostPrice;
        }

        public bool CompareSellingPrice(dynamic d1, dynamic d2)
        {
            return d1.SellingPrice > d2.SellingPrice;
        }

        public bool CompareDiscount(dynamic d1, dynamic d2)
        {
            return d1.Discount > d2.Discount;
        }

        public bool CompareRealPrice(dynamic d1, dynamic d2)
        {
            return d1.RealPrice > d2.RealPrice;
        }

        public List<dynamic> SortListBookView(List<dynamic> data, string sort)
        {
            Compare cmp;
            if (sort == "ID") cmp = CompareIDBook;
            else if (sort == "Name") cmp = CompareNameBook;
            else if (sort == "Author") cmp = CompareAuthor;
            else if (sort == "Publisher") cmp = CompareNamePublisher;
            else if (sort == "Publishing year") cmp = CompareYearPublish;
            else if (sort == "Remaining amount") cmp = CompareRemainingAmount;
            else if (sort == "Cost price") cmp = CompareCostPrice;
            else if (sort == "Selling price") cmp = CompareSellingPrice;
            else if (sort == "Discount") cmp = CompareDiscount;
            else if (sort == "Real price") cmp = CompareRealPrice;
            else return data;
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (cmp(data[i], data[j]))
                    {
                        (data[i], data[j]) = (data[j], data[i]);
                    }
                }
            }
            return data;
        }
    }
}