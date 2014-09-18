﻿namespace TravelWithMe.Web.Models
{
    using TravelWithMe.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    public class TravelDescriptionModels
    {
        public static Expression<Func<Travel, TravelDescriptionModels>> FromTravel
        {
            get
            {
                return a => new TravelDescriptionModels
                {
                    SpendingTime = a.SpendingTime,
                    StartLocationId = a.StartLocationId,
                    StartLocation = a.StartLocation,
                    EndLocation = a.EndLocation,
                    Description = a.Description,
                };
            }
        }

        public string Description { get; set; }

        [Required]
        public int StartLocationId { get; set; }

        public TimeSpan? SpendingTime { get; set; }

        public City StartLocation { get; set; }

        public City EndLocation { get; set; }
    }
}