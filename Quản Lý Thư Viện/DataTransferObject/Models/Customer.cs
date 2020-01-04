using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public virtual ICollection<CustomerBooks> Books { get; set; }

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

            //return new Customer
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Email = this.Email,
            //    Birthday = this.Birthday,
            //    Books = this.Books,
            //};
        }
    }
}
