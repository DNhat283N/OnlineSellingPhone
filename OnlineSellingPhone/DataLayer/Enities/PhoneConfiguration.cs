using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Enities
{
    [Table("PhoneConfiguration")]
    public class PhoneConfiguration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhoneConfiguration_ID { get; set; }

        [Column]
        [Required]
        public int Phone_ID { get; set; }
        [ForeignKey("Phone_ID")]
        public virtual Phone phone { get; set; }

        public int Configuration_ID { get; set; }
        [ForeignKey("Configuration_ID")]
        public virtual Configuration config { get; set; }


        public PhoneConfiguration() { }
        public PhoneConfiguration(int phoneID, int configurationID)
        {
            Phone_ID = phoneID;
            Configuration_ID = configurationID;
        }
    }
}
