using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetail_ID { get; set; }
        
        [Column]
        [Required]
        public int OrderDetail_Quantity { get; set; }

        [Column]
        [Required]
        public DateTime OrderDate { get; set; }

        [Column]
        [Required]
        public int Phone_ID { get; set; }

        [ForeignKey("Phone_ID")]
        public virtual Phone Phone { get; set; }

        [Column]
        [Required]
        public int Order_ID { get; set; }
        [ForeignKey("Order_ID")]
        public virtual Order Order { get; set; }

    }
}
