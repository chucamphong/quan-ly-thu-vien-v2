using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class Publisher : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
    }
}
