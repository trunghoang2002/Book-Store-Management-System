using QLNS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BLL
{
    public class BLL_Login
    {
        public int id_account = 0;
        public string username;
        public string password;
        public int id_role;

        private static BLL_Login _Instance;
        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Login();
                return _Instance;
            }
            private set { }
        }

        private BLL_Login() { }

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        
        //public string Base64Decode(string base64EncodedData)
        //{
        //    var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        //    return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        //}

        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public string EncodePass(string pass)
        {
            return MD5Hash(Base64Encode(pass));
        }

        public bool CheckLogin(string username, string password)
        {
            User_Account result = GetAccount(username, password);
            if (result != null)
            {
                this.id_account = result.ID_Account;
                this.username = result.UserName;
                this.password = result.Password;
                this.id_role = result.ID_Role;
                return true;
            }
            return false;
        }

        public User_Role GetRole()
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                User_Role data = new User_Role();
                data = db.User_Roles.Where(x => x.ID_Role == this.id_role).FirstOrDefault();
                return data;
            }
        }

        public User_Account GetAccount(string username, string password)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                User_Account data = new User_Account();
                string pass = EncodePass(password);
                data = db.User_Accounts.Where(p => p.IsDeleted == false && p.UserName == username && p.Password == pass).FirstOrDefault();
                return data;
            }
        }

        public Staff GetStaff()
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                Staff data = new Staff();
                data = db.Staffs.Where(x => x.ID_Account == this.id_account).FirstOrDefault();
                return data;
            }
        }

        public bool CheckOldPass(string oldPass)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                if (this.password == EncodePass(oldPass))
                    return true;
                return false;
            }
        }

        public void ChangePass(string newPass)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                User_Account data = new User_Account();
                data = db.User_Accounts.Where(x => x.ID_Account == this.id_account).FirstOrDefault();
                data.Password = EncodePass(newPass);
                db.SaveChanges();
            }
        }

        public void ResetPassword(int idStaff)
        {
            using (QLNS_Entity db = new QLNS_Entity())
            {
                User_Account uc = db.User_Accounts.Where(x => x.Staffs.FirstOrDefault().ID_Staff == idStaff).FirstOrDefault();
                uc.Password = EncodePass("User@123");
                this.password = uc.Password;
                db.SaveChanges();
            }
        }
    }
}