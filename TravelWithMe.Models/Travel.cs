namespace TravelWithMe.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Travel
    {
<<<<<<< HEAD
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual TravelWithMeUser User { get; set; }

        public DateTime TravelDate { get; set; }

        public int StartLocationId { get; set; }

        public virtual City StartLocation { get; set; }

        public int EndLocatonId { get; set; }

        public virtual City EndLocation { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}
=======
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
>>>>>>> origin/master
