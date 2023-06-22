using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        [Required]
        public int ID_Category { get; set; }
        [StringLength(50)]
        [Required]
        public string NameCategory { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
