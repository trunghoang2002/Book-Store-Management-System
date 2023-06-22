using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    public class Detail_Bill : BaseEntity
    {
        [Key]
        [Required]
        [Column(Order = 1)]
        [ForeignKey("Bill")]
        public int ID_Bill { get; set; }
        [Key]
        [Required]
        [Column(Order = 2)]
        [ForeignKey("Book")]
        public int ID_Book { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Book Book { get; set; }
    }
}
