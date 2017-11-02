using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Translator2.Models
{
    public class Platform
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsActive { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }
    }
}
