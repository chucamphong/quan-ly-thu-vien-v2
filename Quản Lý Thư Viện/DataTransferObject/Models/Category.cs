using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class Category : IEntity
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
