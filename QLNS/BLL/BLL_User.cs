using QLNS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BLL
{
    public class BLL_User
    {
        private static BLL_User _Instance;
        public static BLL_User Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_User();
                return _Instance;
            }
            private set { }
        }

        private BLL_User() { }

        public int GetIDNewStaff()
        {
            int id = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                id = db.Staffs.Max(x => x.ID_Staff) + 1;
            }
            return id;
        }

        public int GetIDNewAccount()
        {
            int id = 0;
            using (QLNS_Entity db = new QLNS_Entity())
            {
                id = db.User_Accounts.Max(x => x.ID_Account) + 1;
            }
            return id;
        }

        public List<dynamic> GetListUserView(string textSearch = "", int idRole = 0)
        {
            List<dynamic> data = new List<dynamic>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (idRole == 0)
                {
                    data = db.Staffs.Where(x => x.IsDeleted == false && (x.NameStaff.Contains(textSearch) || x.PhoneNumber.Contains(textSearch) || x.Email.Contains(textSearch) || x.Address.Contains(textSearch)))
                        .Select(x => new { x.ID_Staff, x.NameStaff, x.Gender, x.DateOfBirth, x.PhoneNumber, x.Email, x.Address, x.User_Account.User_Role.NameRole }).ToList<dynamic>();
                }
                else
                {
                    data = db.Staffs.Where(x => x.IsDeleted == false && x.User_Account.ID_Role == idRole && (x.NameStaff.Contains(textSearch) || x.PhoneNumber.Contains(textSearch) || x.Email.Contains(textSearch) || x.Address.Contains(textSearch)))
                        .Select(x => new { x.ID_Staff, x.NameStaff, x.Gender, x.DateOfBirth, x.PhoneNumber, x.Email, x.Address, x.User_Account.User_Role.NameRole }).ToList<dynamic>();
                }
            }
            return data;
        }

        public List<CBBItem> GetListCBBRole()
        {
            List<CBBItem> data = new List<CBBItem>();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.User_Roles.Select(x => new CBBItem { Value = x.ID_Role, Text = x.NameRole }).ToList();
            }
            return data;
        }

        public Staff GetStaffByID(int id)
        {
            Staff data = new Staff();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Staffs.Find(id);
            }
            return data;
        }

        public User_Role GetRoleByIDStaff(int id)
        {
            User_Role data = new User_Role();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Staffs.Find(id).User_Account.User_Role;
            }
            return data;
        }

        public User_Account GetAccountByIDStaff(int id)
        {
            User_Account data = new User_Account();
            using (QLNS_Entity db = new QLNS_Entity())
            {
                data = db.Staffs.Find(id).User_Account;
            }
            return data;
        }
        public void UpdateUserAccount(User_Account account)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                User_Account uc = db.User_Accounts.Find(account.ID_Account);
                uc.UserName = account.UserName;
                uc.Password = account.Password;
                uc.ID_Role = account.ID_Role;
                db.SaveChanges();
            }
        }

        public void DeleteUserByIDStaff(int idStaff)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                User_Account uc = db.User_Accounts.Where(x => x.Staffs.FirstOrDefault().ID_Staff == idStaff).FirstOrDefault();
                uc.IsDeleted = true;
                Staff staff = db.Staffs.Find(idStaff);
                staff.IsDeleted = true;
                db.SaveChanges();
            }
        }


        public void UpdateStaff(Staff staff)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Staff s = db.Staffs.Find(staff.ID_Staff);
                s.NameStaff = staff.NameStaff;
                s.Gender = staff.Gender;
                s.DateOfBirth = staff.DateOfBirth;
                s.PhoneNumber = staff.PhoneNumber;
                s.Email = staff.Email;
                s.Address = staff.Address;
                db.SaveChanges();
            }
        }

        public void AddUserAccount(User_Account account)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                db.User_Accounts.Add(account);
                db.SaveChanges();
            }
        }
        
        public void AddStaff(Staff staff)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
            }
        }

        public delegate bool Compare(dynamic d1, dynamic d2);

        public bool CompareID_Staff(dynamic d1, dynamic d2)
        {
            return d1.ID_Staff > d2.ID_Staff;
        }

        public bool CompareNameStaff(dynamic d1, dynamic d2)
        {
            return string.Compare(d1.NameStaff, d2.NameStaff) > 0;
        }

        public bool CompareDateOfBirth(dynamic d1, dynamic d2)
        {
            return d1.DateOfBirth > d2.DateOfBirth;
        }

        public bool ComparePhoneNumber(dynamic d1, dynamic d2)
        {
            return string.Compare(d1.PhoneNumber, d2.PhoneNumber) > 0;
        }

        public bool CompareEmail(dynamic d1, dynamic d2)
        {
            return string.Compare(d1.Email, d2.Email) > 0;
        }

        public bool CompareAddress(dynamic d1, dynamic d2)
        {
            return string.Compare(d1.Address, d2.Address) > 0;
        }

        public List<dynamic> SortListUserView(List<dynamic> data, string sort)
        {
            Compare cmp;
            if (sort == "ID") cmp = CompareID_Staff;
            else if (sort == "Name") cmp = CompareNameStaff;
            else if (sort == "Date of birth") cmp = CompareDateOfBirth;
            else if (sort == "Phone number") cmp = ComparePhoneNumber;
            else if (sort == "Email") cmp = CompareEmail;
            else if (sort == "Address") cmp = CompareAddress;
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