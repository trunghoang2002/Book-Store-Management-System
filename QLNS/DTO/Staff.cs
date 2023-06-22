using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    [Table("Staff")]
    public class Staff : BaseEntity
    {
        public Staff()
        {
            this.Bills = new HashSet<Bill>();
            this.Book_Entry_Diarys = new HashSet<Book_Entry_Diary>();
        }

        [Key]
        [Required]
        public int ID_Staff { get; set; }
        [StringLength(50)]
        [Required]
        public string NameStaff { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [ForeignKey("User_Account")]
        public int ID_Account { get; set; }

        public virtual User_Account User_Account { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Book_Entry_Diary> Book_Entry_Diarys { get; set; }
    }
}
