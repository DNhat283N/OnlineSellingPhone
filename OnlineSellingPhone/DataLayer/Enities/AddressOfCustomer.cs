using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("AddressOfCustomers")]
    public class AddressOfCustomer
    {
        [Key]
        [Column(Order = 1)]
        public int Address_ID { get; set; }
        [ForeignKey("Address_ID")]
        public virtual Address Address { get; set; }
        [Key]
        [Column(Order = 2)]
        public int Customer_ID { get; set; }
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }

        public AddressOfCustomer(int address_ID, int customer_ID)
        {
            Address_ID = address_ID;
            Customer_ID = customer_ID;
        }
    }
}
