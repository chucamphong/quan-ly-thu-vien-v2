using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataTransferObject
{
    [Serializable]
    public class Customer : IEntity, ICloneable
    {
        public Customer()
        {
            this.Books = new HashSet<CustomerBooks>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Birthday { get; set; }

        [Required]
        [Phone]
        [StringLength(11, MinimumLength = 10)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4,5})$", ErrorMessage = "Số điện thoại không hợp lệ")]
        [Index(IsUnique = true)]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        public virtual ICollection<CustomerBooks> Books { get; set; }

        public static bool operator ==(Customer customer, Customer other)
        {
            return customer.Id == other.Id &&
                   customer.Name == other.Name &&
                   customer.Email == other.Email &&
                   customer.Birthday == other.Birthday &&
                   customer.Address == other.Address &&
                   customer.Phone == other.Phone;
        }

        public static bool operator !=(Customer customer, Customer other)
        {
            return customer.Id != other.Id &&
                   customer.Name != other.Name &&
                   customer.Email != other.Email &&
                   customer.Birthday != other.Birthday &&
                   customer.Address != other.Address &&
                   customer.Phone != other.Phone;
        }

        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;
                    return formatter.Deserialize(stream);
                }

                return null;
            }
        }
    }
}
