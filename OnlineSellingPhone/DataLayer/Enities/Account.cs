using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Account_ID { get; set; }
        [Column]
        [Required]
        public string Account_Username  { get; set; }
        [Column]
        [Required]
        public string Account_Password { get; set; }
        [Column]
        [Required]
        public int Customer_ID { get; set; }
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }
        [Column]
        [Required]
        public UserRoleEnum userRoleEnum { get; set; } = UserRoleEnum.CUSTOMER;
    }
}
