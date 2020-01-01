using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(32)]
        public string Password { get; set; }
    }
}
