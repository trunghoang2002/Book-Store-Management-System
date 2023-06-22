using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    [Table("Bill")]
    public class Bill : BaseEntity
    {
        public Bill()
        {
            this.Detail_Bills = new HashSet<Detail_Bill>();
        }

        [Key]
        [Required]
        public int ID_Bill { get; set; }
        [StringLength(50)]
        public string NameCustomer { get; set; }
        public DateTime DatePay { get; set; }
        public decimal TotalCost { get; set; }
        [ForeignKey("Payment")]
        [Required]
        public int ID_Payment { get; set; }
        [ForeignKey("Staff")]
        [Required]
        public int ID_Staff { get; set; }

        public virtual Payment Payment { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<Detail_Bill> Detail_Bills { get; set; }
    }
}
