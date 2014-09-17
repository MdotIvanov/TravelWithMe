using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelWithMe.Models
{
    public class Travel
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public int StartCityId { get; set; }

        [Required]
        public int EndCityId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int UserId { get; set; }

        public string Content { get; set; }

    }
}
