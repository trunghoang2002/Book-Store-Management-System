using QLNS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    public class CreateDB : CreateDatabaseIfNotExists<QLNS_Entity>
                            //DropCreateDatabaseIfModelChanges<QLNS_Entity>
                            //DropCreateDatabaseAlways<QLNS_Entity>
    {
        protected override void Seed(QLNS_Entity context)
        {
            context.User_Roles.AddRange(new User_Role[]
            {
                new User_Role { ID_Role = 1, NameRole = "Admin" },
                new User_Role { ID_Role = 2, NameRole = "Salesman" },
                new User_Role { ID_Role = 3, NameRole = "Stocker" },
            });
            context.User_Accounts.AddRange(new User_Account[]
            {
                new User_Account { ID_Account = 1, UserName = "hoang", Password = "58f966188228db3f156986c915be3f89", ID_Role = 1 }, // Hoang@123
                new User_Account { ID_Account = 2, UserName = "quoc", Password = "55f094cdce340d964f84a68fdd4b25af", ID_Role = 1 }, // Quoc@123
                new User_Account { ID_Account = 3, UserName = "nam", Password = "3f5efc5ccbd5e0bac87da282b8022112", ID_Role = 2 }, // Nam@123
                new User_Account { ID_Account = 4, UserName = "ngo", Password = "90e9d76a4c6b518cf7e7b71cb5e919a9", ID_Role = 3 } // Ngo@123
            });
            context.Staffs.AddRange(new Staff[]
            {
                new Staff { ID_Staff = 1, NameStaff = "Lê Trung Hoàng", DateOfBirth = Convert.ToDateTime("2002/12/04"), Gender = true, PhoneNumber = "0964696074", Email = "trunghoang04122002@gmail.com", Address = "Sơn Trà", ID_Account = 1 },
                new Staff { ID_Staff = 2, NameStaff = "Nguyễn Kiều Quốc", DateOfBirth = Convert.ToDateTime("2002/10/30"), Gender = true, PhoneNumber = "0935102824", Email = "nguyenkieuquoc3010@gmail.com", Address = "Đà Nẵng" , ID_Account = 2 },
                new Staff { ID_Staff = 3, NameStaff = "Bùi Hải Nam", DateOfBirth = Convert.ToDateTime("2002/11/10"), Gender = true, PhoneNumber = "0332086927", Email = "hainamlak12@gmail.com", Address = "Đăk Lăk" , ID_Account = 3 },
                new Staff { ID_Staff = 4, NameStaff = "Lê Huy Ngọ", DateOfBirth = Convert.ToDateTime("2002/03/08"), Gender = true, PhoneNumber = "0981060034", Email = "ngomun20@gmail.com", Address = "Quảng Ngãi" , ID_Account = 4 }
            });
            context.Publishes.AddRange(new Publish[]
            {
                new Publish { ID_Publish = 1, NamePublisher = "NXB GIÁO DỤC" },
                new Publish { ID_Publish = 2, NamePublisher = "NXB HỒNG ĐỨC" },
                new Publish { ID_Publish = 3, NamePublisher = "NXB KIM ĐỒNG" },
                new Publish { ID_Publish = 4, NamePublisher = "NXB TỔNG HỢP TPHCM" },
                new Publish { ID_Publish = 5, NamePublisher = "NXB LAO ĐỘNG" },
                new Publish { ID_Publish = 6, NamePublisher = "NXB THANH NIÊN" },
                new Publish { ID_Publish = 7, NamePublisher = "NXB PHỤ NỮ" },
                new Publish { ID_Publish = 8, NamePublisher = "NXB CÔNG THƯƠNG" }
            });
            context.Categories.AddRange(new Category[]
            {
                new Category { ID_Category = 1, NameCategory = "KINH DOANH" },
                new Category { ID_Category = 2, NameCategory = "PHÁT TRIỂN BẢN THÂN" },
                new Category { ID_Category = 3, NameCategory = "SỨC KHỎE" },
                new Category { ID_Category = 4, NameCategory = "TRUYỆN, TIỂU THUYẾT" },
                new Category { ID_Category = 5, NameCategory = "VĂN HỌC NGHỆ THUẬT" },
                new Category { ID_Category = 6, NameCategory = "SÁCH THIẾU NHI" },
                new Category { ID_Category = 7, NameCategory = "TÂM LÝ GIÁO DỤC" },
                new Category { ID_Category = 8, NameCategory = "TÂM LINH" }
            });
            context.Books.AddRange(new Book[]
            {
                new Book { ID_Book = 1, NameBook = "CHĂM SÓC DA TẠI NHÀ TỪ A ĐẾN Z", Author = "B.S NGUYỄN NGỌC" , CostPrice = 300000 , ID_Category = 7, ID_Publish = 2, YearPublish = 2022 , Edition = 1 , SellingPrice = 386000 },
                new Book { ID_Book = 2, NameBook = "HO’OPONOPONO - PHỤC HỒI TỰ NHIÊN, CHỮA LÀNH CUỘC SỐNG, HOÀN THIỆN CUỘC ĐỜI", Author = "ULRICH E.DUPRÉE" , CostPrice = 40000 , ID_Category = 3, ID_Publish = 2, YearPublish = 2021 , Edition = 1 , SellingPrice = 66000 },
                new Book { ID_Book = 3, NameBook = "22 NGÀY CÁCH MẠNG CƠ THỂ", Author = "MARCO BORGES" , CostPrice = 140000 , ID_Category = 3, ID_Publish = 2, YearPublish = 2019 , Edition = 1 , SellingPrice = 188000 },
                new Book { ID_Book = 4, NameBook = "10 PHÚT TĨNH TÂM - 71 THÓI QUEN CÂN BẰNG CUỘC SỐNG HIỆN ĐẠI", Author = "S.J. SCOTT VÀ BARRIE DAVENPORT" , CostPrice = 160000 , ID_Category = 3, ID_Publish = 2, YearPublish = 2019 , Edition = 1 , SellingPrice = 169000 },
                new Book { ID_Book = 5, NameBook = "MẬT MÃ CẢM XÚC: 5 BƯỚC GIÚP BẠN BƯỚC RA BẪY CẢM XÚC", Author = "DR.BRADLEY NELSON" , CostPrice = 80000 , ID_Category = 3, ID_Publish = 2, YearPublish = 2021 , Edition = 1 , SellingPrice = 168000 },
                new Book { ID_Book = 6, NameBook = "ĐẮC NHÂN TÂM", Author = "DALE CARNEGIE" , CostPrice = 140000 , ID_Category = 2, ID_Publish = 2, YearPublish = 2019 , Edition = 1 , SellingPrice = 150000 },
                new Book { ID_Book = 7, NameBook = "SỐNG ĐẸP - NGHỆ THUẬT SỐNG TRỌN VẸN", Author = "NGUYỄN HIẾN LÊ" , CostPrice = 140000 , ID_Category = 2, ID_Publish = 2, YearPublish = 2018 , Edition = 1 , SellingPrice = 153000 },
                new Book { ID_Book = 8, NameBook = "ĐÁNH THỨC ĐAM MÊ: LÀM THẾ NÀO ĐỂ TẠO RA CON NGƯỜI PHI THƯỜNG TRONG BẠN", Author =  "NAOMI SIMSON" , CostPrice = 175000 , ID_Category = 2, ID_Publish = 2, YearPublish = 2020 , Edition = 1 , SellingPrice = 182000 },
                new Book { ID_Book = 9, NameBook = "ĐỪNG BAO GIỜ TỪ BỎ GIẤC MƠ", Author = "CHIP GAINES" , CostPrice = 140000 , ID_Category = 2, ID_Publish = 2, YearPublish = 2019 , Edition = 1 , SellingPrice = 154000 },
                new Book { ID_Book = 10, NameBook = "KỸ NĂNG ĐỂ CÂN BẰNG GIỮA CÔNG VIỆC VÀ CUỘC SỐNG", Author = "STEWART D. FRIEDMAN" , CostPrice = 166000 , ID_Category = 2, ID_Publish = 2, YearPublish = 2020 , Edition = 1 , SellingPrice = 176000 },
                new Book { ID_Book = 11, NameBook = "NGHĨ GIÀU & LÀM GIÀU (TÁI BẢN 2020)", Author = "NAPOLEON HILL" , CostPrice = 60000 , ID_Category = 1, ID_Publish = 4, YearPublish = 2020 , Edition = 2 , SellingPrice = 88000 },
                new Book { ID_Book = 12, NameBook = "BÍ MẬT TƯ DUY TRIỆU PHÚ (TÁI BẢN 2021)", Author = "T HARV EKER" , CostPrice = 80000 , ID_Category = 1, ID_Publish = 4, YearPublish = 2021 , Edition = 2 , SellingPrice = 88560 },
                new Book { ID_Book = 13, NameBook = "KỸ NĂNG QUẢN LÝ NHÂN SỰ CHUYÊN NGHIỆP", Author = "Whitney Johnson" , CostPrice = 90000 , ID_Category = 1, ID_Publish = 5, YearPublish = 2019 , Edition = 1 , SellingPrice = 95200 },
                new Book { ID_Book = 14, NameBook = "BÁN HÀNG SHOPEE THỰC CHIẾN TỪ A-Z - 36 CHIẾN LƯỢC ĐỈNH CAO BÙNG NỔ DOANH SỐ", Author = "VĂN CHÍNH" , CostPrice = 240000 , ID_Category = 1, ID_Publish = 6, YearPublish = 2021 , Edition = 3, SellingPrice = 249000 },
                new Book { ID_Book = 15, NameBook = "7 PHƯƠNG PHÁP ĐẦU TƯ WARREN BUFFET", Author = "MARY BUFFETT, SEAN SEAH" , CostPrice = 130000 , ID_Category = 1, ID_Publish = 8, YearPublish = 2019 , Edition = 1 , SellingPrice = 139000 }
            });
            context.Book_Discounts.AddRange(new Book_Discount[]
            {
                new Book_Discount { ID_Book_Discount = 1, Discount = 15 },
                new Book_Discount { ID_Book_Discount = 2, Discount = 30 },
                new Book_Discount { ID_Book_Discount = 3, Discount = 20.23M },
                new Book_Discount { ID_Book_Discount = 4, Discount = 0 },
                new Book_Discount { ID_Book_Discount = 5, Discount = 50 },
                new Book_Discount { ID_Book_Discount = 6, Discount = 0 },
                new Book_Discount { ID_Book_Discount = 7, Discount = 0 },
                new Book_Discount { ID_Book_Discount = 8, Discount = 0 },
                new Book_Discount { ID_Book_Discount = 9, Discount = 0 },
                new Book_Discount { ID_Book_Discount = 10, Discount = 38 },
                new Book_Discount { ID_Book_Discount = 11, Discount = 0 },
                new Book_Discount { ID_Book_Discount = 12, Discount = 0 },
                new Book_Discount { ID_Book_Discount = 13, Discount = 40 },
                new Book_Discount { ID_Book_Discount = 14, Discount = 0 },
                new Book_Discount { ID_Book_Discount = 15, Discount = 0 }
            });
            context.Book_Warehouses.AddRange(new Book_Warehouse[]
            {
                new Book_Warehouse { ID_Book_Warehouse = 1, TotalAmount = 100, RemainingAmount = 75 },
                new Book_Warehouse { ID_Book_Warehouse = 2, TotalAmount = 50, RemainingAmount = 24 },
                new Book_Warehouse { ID_Book_Warehouse = 3, TotalAmount = 200, RemainingAmount = 134 },
                new Book_Warehouse { ID_Book_Warehouse = 4, TotalAmount = 150, RemainingAmount = 140 },
                new Book_Warehouse { ID_Book_Warehouse = 5, TotalAmount = 50, RemainingAmount = 40 },
                new Book_Warehouse { ID_Book_Warehouse = 6, TotalAmount = 60, RemainingAmount = 38 },
                new Book_Warehouse { ID_Book_Warehouse = 7, TotalAmount = 89, RemainingAmount = 80 },
                new Book_Warehouse { ID_Book_Warehouse = 8, TotalAmount = 150, RemainingAmount = 100 },
                new Book_Warehouse { ID_Book_Warehouse = 9, TotalAmount = 130, RemainingAmount = 124 },
                new Book_Warehouse { ID_Book_Warehouse = 10, TotalAmount = 67, RemainingAmount = 25 },
                new Book_Warehouse { ID_Book_Warehouse = 11, TotalAmount = 99, RemainingAmount = 78 },
                new Book_Warehouse { ID_Book_Warehouse = 12, TotalAmount = 143, RemainingAmount = 140 },
                new Book_Warehouse { ID_Book_Warehouse = 13, TotalAmount = 180, RemainingAmount = 130 },
                new Book_Warehouse { ID_Book_Warehouse = 14, TotalAmount = 250, RemainingAmount = 180 },
                new Book_Warehouse { ID_Book_Warehouse = 15, TotalAmount = 210, RemainingAmount = 200 }
            });
            context.Book_Entry_Diarys.AddRange(new Book_Entry_Diary[]
            {
                new Book_Entry_Diary { ID_Book = 1, Amount = 56, Price = 300000, DateEntry = Convert.ToDateTime("2022/05/05") , ID_Staff = 1 },
                new Book_Entry_Diary { ID_Book = 2, Amount = 76, Price = 40000, DateEntry = Convert.ToDateTime("2022/04/18") , ID_Staff = 1 },
                new Book_Entry_Diary { ID_Book = 3, Amount = 43, Price = 140000, DateEntry = Convert.ToDateTime("2022/01/12") , ID_Staff = 3 },
                new Book_Entry_Diary { ID_Book = 1, Amount = 24, Price = 300000, DateEntry = Convert.ToDateTime("2020/01/03") , ID_Staff = 2 },
                new Book_Entry_Diary { ID_Book = 4, Amount = 52, Price = 160000, DateEntry = Convert.ToDateTime("2022/03/20") , ID_Staff = 1 },
                new Book_Entry_Diary { ID_Book = 5, Amount = 45, Price = 80000, DateEntry = Convert.ToDateTime("2022/02/16") , ID_Staff = 2 },
                new Book_Entry_Diary { ID_Book = 6, Amount = 67, Price = 140000, DateEntry = Convert.ToDateTime("2022/01/25") , ID_Staff = 3 }
            });
            context.Payments.AddRange(new Payment[]
            {
                new Payment { ID_Payment = 1, NamePayment = "THANH TOÁN BẰNG ATM" },
                new Payment { ID_Payment = 2, NamePayment = "THANH TOÁN TRỰC TIẾP" },
                new Payment { ID_Payment = 3, NamePayment = "THANH TOÁN QUA MÃ QR" }
            });
            context.Bills.AddRange(new Bill[]
            {
                new Bill { ID_Bill = 1, NameCustomer = "TRƯƠNG THỊ THANH THÚY" , DatePay = Convert.ToDateTime("2022/03/04") , TotalCost = 46200, ID_Payment = 1 , ID_Staff = 1 },
                new Bill { ID_Bill = 2, NameCustomer = "NGUYỄN THỊ THANH NGA" , DatePay = Convert.ToDateTime("2022/01/16"), TotalCost = 233967.6M,  ID_Payment = 2 , ID_Staff = 2 },
                new Bill { ID_Bill = 3, NameCustomer = "LÊ VĂN LUÂN" , DatePay = Convert.ToDateTime("2021/12/01") , TotalCost = 92400, ID_Payment = 3 , ID_Staff = 2 },
                new Bill { ID_Bill = 4, NameCustomer = "LƯƠNG QUỐC TUẤN" , DatePay = Convert.ToDateTime("2021/11/19") , TotalCost = 656200, ID_Payment = 2 , ID_Staff = 1 },
                new Bill { ID_Bill = 5, NameCustomer = "NGUYỄN QUANG DUY" , DatePay = Convert.ToDateTime("2021/06/26") , TotalCost = 149967.6M, ID_Payment = 1 , ID_Staff = 3 },
                new Bill { ID_Bill = 6, NameCustomer = "ĐỖ TẤN TÀI" , DatePay = Convert.ToDateTime("2021/08/16") , TotalCost = 88000, ID_Payment = 2 , ID_Staff = 2 }
            });
            context.Detail_Bills.AddRange(new Detail_Bill[]
            {
                new Detail_Bill { ID_Bill = 1, ID_Book = 2, Amount = 1, Price = 46200 },
                new Detail_Bill { ID_Bill = 2, ID_Book = 5, Amount = 1, Price = 84000 },
                new Detail_Bill { ID_Bill = 2, ID_Book = 3, Amount = 1, Price = 149967.6M },
                new Detail_Bill { ID_Bill = 3, ID_Book = 2, Amount = 2, Price = 46200 },
                new Detail_Bill { ID_Bill = 4, ID_Book = 1, Amount = 2, Price = 328100 },
                new Detail_Bill { ID_Bill = 5, ID_Book = 3, Amount = 1, Price = 149967.6M },
                new Detail_Bill { ID_Bill = 6, ID_Book = 6, Amount = 1, Price = 88000 }
            });
        }
    }
}
