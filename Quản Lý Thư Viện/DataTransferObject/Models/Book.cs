using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class Book : IEntity
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
            this.Categories = new HashSet<Category>();
        }

        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
