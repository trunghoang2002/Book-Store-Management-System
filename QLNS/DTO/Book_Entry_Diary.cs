using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    public class Book_Entry_Diary : BaseEntity
    {
        [Key]
        [Required]
        [Column(Order = 1)]
        [ForeignKey("Book")]
        public int ID_Book { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        [Key]
        [Required]
        [Column(Order = 2)]
        public DateTime DateEntry { get; set; }
        [Key]
        [Required]
        [Column(Order = 3)]
        [ForeignKey("Staff")]
        public int ID_Staff { get; set; }

        public virtual Book Book { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
