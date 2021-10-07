using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HoodooDonuts.Models
{
    public class Donut
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string DonutId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Type { get; set; }

    }
}
