using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
        }

        public int Id { get; set; }

        [Required]
        [Index("Unique_Book_Name", IsUnique = true)]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
