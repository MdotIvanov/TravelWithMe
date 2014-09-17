namespace TravelWithMe.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Travel
    {
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
