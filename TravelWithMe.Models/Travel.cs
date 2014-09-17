namespace TravelWithMe.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

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