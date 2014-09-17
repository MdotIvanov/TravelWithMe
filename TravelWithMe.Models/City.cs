namespace TravelWithMe.Models
{
    using System.ComponentModel.DataAnnotations;

    public class City
    {
<<<<<<< HEAD
=======
        [Key]
>>>>>>> origin/master
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
<<<<<<< HEAD
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
=======
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
>>>>>>> origin/master
