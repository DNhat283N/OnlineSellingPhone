using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("PhoneNumber")]
    public class PhoneNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhoneNumber_ID { get; set; }
        [Column]
        [Required]
        [MaxLength(10)]
        public string PhoneNumber_Number { get; set; }
        [Column]
        [Required]
        public int Customer_ID { get; set; }
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }
    }
}
