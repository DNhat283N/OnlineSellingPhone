using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("Configuration")]
    public class Configuration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Configuration_ID { get; set; }

        [Column]
        [Required]
        public int Configuration_RAM { get; set; }

        [Column]
        [Required]
        public int Configuration_ROM { get; set; }

        public Configuration() { }
        public Configuration(int RAM, int ROM)
        {
            Configuration_RAM = RAM;
            Configuration_ROM = ROM;
        }
    }
}
