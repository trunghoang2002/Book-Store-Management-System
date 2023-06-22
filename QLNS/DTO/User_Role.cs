using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    public class User_Role : BaseEntity
    {
        public User_Role()
        {
            this.User_Accounts = new HashSet<User_Account>();
        }

        [Key]
        [Required]
        public int ID_Role { get; set; }
        [Required]
        [StringLength(50)]
        public string NameRole { get; set; }

        public virtual ICollection<User_Account> User_Accounts { get; set; }
    }
}
