using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class User : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(255)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(32)]
        public string Password { get; set; }
    }
}
