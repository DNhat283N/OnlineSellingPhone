using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Enities
{
    [Table("Images")]
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Image_ID { get; set; }
        [Column]
        [Required]
        public string Image_URL { get; set; }
        [Column]
        [Required]
        public int Phone_ID { get; set; }
        [ForeignKey("Phone_ID")]
        public virtual Phone Phone{ get; set; }
    }
}
