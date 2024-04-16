using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Customer_ID { get; set; }
        [Column]
        [MaxLength(35)]
        [Required]
        public string Customer_FName { get; set; }
        [Column]
        [Required]
        public DateTime Customer_BirthDay { get; set; }
        [Column]
        [Required]
        public Boolean Customer_Gender { get; set; }


        public Customer(string fname, bool gender, DateTime birthday)
        {
            this.Customer_FName = fname;
            this.Customer_Gender = gender;
            this.Customer_BirthDay = birthday;
        }

        public Customer()
        {
        }
    }
}
