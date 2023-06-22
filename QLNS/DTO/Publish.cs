using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    [Table("Publish")]
    public class Publish : BaseEntity
    {
        public Publish()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        [Required]
        public int ID_Publish { get; set; }
        [StringLength(50)]
        [Required]
        public string NamePublisher { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
