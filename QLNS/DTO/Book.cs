using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DTO
{
    [Table("Book")]
    public class Book : BaseEntity
    {
        public Book()
        {
            this.Book_Entry_Diarys = new HashSet<Book_Entry_Diary>();
            this.Detail_Bills = new HashSet<Detail_Bill>();
        }
        
        [Key]
        [Required]
        public int ID_Book { get; set; }
        [StringLength(200)]
        public string NameBook { get; set; }
        [StringLength(100)]
        public string Author { get; set; }
        public decimal CostPrice { get; set; }
        [ForeignKey("Category")]
        [Required]
        public int ID_Category { get; set; }
        [ForeignKey("Publish")]
        [Required]
        public int ID_Publish { get; set; }
        public int YearPublish { get; set; }
        public int Edition { get; set; }
        public decimal SellingPrice { get; set; }

        public virtual Category Category { get; set; }
        public virtual Publish Publish { get; set; }
        public virtual ICollection<Book_Entry_Diary> Book_Entry_Diarys { get; set; }
        public virtual Book_Warehouse Book_Warehouse { get; set; }
        public virtual ICollection<Detail_Bill> Detail_Bills { get; set; }
        public virtual Book_Discount Book_Discount { get; set; }
    }
}
