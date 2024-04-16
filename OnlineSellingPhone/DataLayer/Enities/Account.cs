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
        public UserRoleEnum Account_UserRoleEnum { get; set; } = UserRoleEnum.CUSTOMER;

        public Account(string account_Username, string account_Password, int customer_ID, UserRoleEnum account_UserRoleEnum = UserRoleEnum.CUSTOMER)
        {
            Account_Username = account_Username;
            Account_Password = account_Password;
            Customer_ID = customer_ID;
            Account_UserRoleEnum = account_UserRoleEnum;
        }
    }
}
