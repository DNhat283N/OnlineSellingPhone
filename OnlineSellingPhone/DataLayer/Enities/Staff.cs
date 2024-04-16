using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("Staffs")]
    public class Staff: Customer
    {
        [Column]
        [Required]
        public DateTime Staff_FirsDayOfWork { get; set; }
        [Column]
        [Required]
        [MaxLength(20)]
        public string Staff_Posistion { get; set; }

        public Staff(string fname, bool gender, DateTime birthday, DateTime staff_FirsDayOfWork, string staff_Posistion)
        {
            Staff_FirsDayOfWork = staff_FirsDayOfWork;
            Staff_Posistion = staff_Posistion;
        }
    }
}
