using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class Author : IEntity
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string Name { get; set; }

        [Browsable(false)]
        public virtual ICollection<Book> Books { get; set; }
    }
}
