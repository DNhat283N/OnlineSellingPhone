using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("Phone")]
    public class Phone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Phone_ID { get; set; }
        [Column]
        [MaxLength(50)]
        [Required]
        public string Phone_Name { get; set; }
        [Column]
        [MaxLength(7), MinLength(7)]
        [Required]
        public string  Phone_Color { get; set; }
        [Column]
        [Required]
        public double Phone_Price { get; set; }
        [Column]
        [Required]
        public int Phone_ReadyInStock { get; set; }
        [Column]
        [Required]
        public int Manufacturer_ID { get; set; }
        [ForeignKey("Manufacturer_ID")]
        public virtual Manufacturer Manufacturer { get; set; }


        public Phone() { }
        public Phone(string phone_Name, string phone_Color, double phone_Price, int phone_ReadyInStock, int manufacturer_ID)
        {
            Phone_Name = phone_Name;
            Phone_Color = phone_Color;
            Phone_Price = phone_Price;
            Phone_ReadyInStock = phone_ReadyInStock;
            Manufacturer_ID = manufacturer_ID;
        }
    }
}
