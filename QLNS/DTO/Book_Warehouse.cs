using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    public class Book_Warehouse : BaseEntity
    {
        [Key]
        [Required]
        [ForeignKey("Book")]
        public int ID_Book_Warehouse { get; set; }
        public int TotalAmount { get; set; }
        public int RemainingAmount { get; set; }

        public virtual Book Book { get; set; }
    }
}
