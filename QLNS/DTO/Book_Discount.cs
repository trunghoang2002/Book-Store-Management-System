using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    public class Book_Discount : BaseEntity
    {
        [Key]
        [Required]
        [ForeignKey("Book")]
        public int ID_Book_Discount { get; set; }
        public decimal Discount { get; set; }

        public virtual Book Book { get; set; }
    }
}
