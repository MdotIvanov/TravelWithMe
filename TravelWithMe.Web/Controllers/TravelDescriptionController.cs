﻿namespace TravelWithMe.Web.Controllers
{
    using TravelWithMe.Data;
    using TravelWithMe.Models;
    using TravelWithMe.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class TravelDescriptionController : ApiController
    {
        private TravelWithMeData db = new TravelWithMeData();

        // GET travel description/
        public HttpResponseMessage GetAllTravels()
        {
            var travels = this.db.Travels.All().Select(TravelDescriptionModels.FromTravel);

            return Request.CreateResponse(HttpStatusCode.OK, travels);
        }

        // GET travel info/1
        public HttpResponseMessage GetTravelById(int startLocationId)
        {
            var travelToGet = this.db.Travels.All().Where(travels => travels.StartLocationId == startLocationId).Select(TravelDescriptionModels.FromTravel).FirstOrDefault();
            if (travelToGet == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Travel does not exist.");
            }
            return Request.CreateResponse(HttpStatusCode.OK, travelToGet);
        }

        // POST travel info/
        public HttpResponseMessage Addtravel([FromBody]TravelDescriptionModels newTravel)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid new travel.");
            }

            this.db.Travels.Add(new Travel()
            {
                StartLocationId = newTravel.StartLocationId,
                StartLocation = newTravel.StartLocation,
                EndLocation = newTravel.EndLocation,
                Description = newTravel.Description,
            });
            this.db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK, "Travel added.");
        }

        //PUT travel info/1
        [HttpPut]
        public HttpResponseMessage UpdateFileDescription(int startLocationId, [FromBody]string newFileDescription)
        {
            var travelToUpdate = this.db.Travels.All().FirstOrDefault(travel => travel.StartLocationId == startLocationId);
            if (travelToUpdate == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Travel does not exist.");
            }

            travelToUpdate.Description = newFileDescription;
            this.db.Travels.Update(travelToUpdate);
            this.db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Travel updated.");
        }

        // DELETE travel info/1
        [HttpDelete]
        public HttpResponseMessage Delete(int startLocationId)
        {
            var travelToDelete = this.db.Travels.All().FirstOrDefault(travel => travel.StartLocationId == startLocationId);
            if (travelToDelete == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Travel does not exist.");
            }

            this.db.Travels.Delete(travelToDelete);
            this.db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Travel deleted");
        }
    }
}