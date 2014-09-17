using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelWithMe.Models
{
    public class User
    {
        private ICollection<Travel> travels;

        public User()
        {
            this.travels = new HashSet<Travel>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        public string Password { get; set; }

        public string Phone { get; set; }

        public virtual 

        public ICollection<Travel> Travels
        {
            get
            {
                return this.travels;
            }
            set
            {
                this.travels = value;
            }
        }
    }
}
