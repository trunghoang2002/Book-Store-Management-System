using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    [Table("Payment")]
    public class Payment : BaseEntity
    {
        public Payment()
        {
            this.Bills = new HashSet<Bill>();
        }

        [Key]
        [Required]
        public int ID_Payment { get; set; }
        [StringLength(50)]
        [Required]
        public string NamePayment { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
