using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelWithMe.Models
{
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
