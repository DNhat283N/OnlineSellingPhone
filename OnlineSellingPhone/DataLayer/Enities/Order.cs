using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_ID { get; set; }

        [Column]
        [Required]
        public double Order_TotalAmount { get; set; }

        [Column]
        [Required]
        public int Customer_ID { get; set; }
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }

        public Order(double order_TotalAmount, int customer_ID)
        {
            Order_TotalAmount = order_TotalAmount;
            Customer_ID = customer_ID;
        }
    }
}
