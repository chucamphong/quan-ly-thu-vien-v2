using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class CustomerBooks
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Book")]
        public virtual int Book_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Customer")]
        public virtual int Customer_Id { get; set; }

        public virtual Book Book { get; set; }

        public virtual Customer Customer { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}
