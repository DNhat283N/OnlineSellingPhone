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
        public Account()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Account_ID { get; set; }
        [Column]
        [Required]
        [MaxLength(15), MinLength(3)]
        [Index(IsUnique = true)]
        public string Account_Username  { get; set; }
        [Column]
        [Required]
        
        public string Account_Password { get; set; }
        [Column]
        [Required]
        [MaxLength(30), MinLength(5)]
        [Index(IsUnique = true)]
        public string Account_Email { get; set; }
        [Column]
        [Required]
        public int Customer_ID { get; set; }
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }
        [Column]
        [Required]
        public UserRoleEnum Account_UserRoleEnum { get; set; } = UserRoleEnum.CUSTOMER;

        public Account(string account_Username, string account_Password, string account_Email, int customer_ID, UserRoleEnum account_UserRoleEnum = UserRoleEnum.CUSTOMER)
        {
            Account_Username = account_Username;
            Account_Password = account_Password;
            Customer_ID = customer_ID;
            Account_UserRoleEnum = account_UserRoleEnum;
            Account_Email = account_Email;
        }
    }
}
