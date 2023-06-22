using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    public class User_Account : BaseEntity
    {
        public User_Account()
        {
            this.Staffs = new HashSet<Staff>();
        }

        [Key]
        [Required]
        public int ID_Account { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        [ForeignKey("User_Role")]
        public int ID_Role { get; set; }

        public virtual User_Role User_Role { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
