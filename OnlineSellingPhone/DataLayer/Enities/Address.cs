using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Address_ID { get; set; }
        [Column]
        [Required]
        [MaxLength(50)]
        public string Address_String { get; set; }

        public Address(string address_String)
        {
            Address_String = address_String;
        }
    }
}
