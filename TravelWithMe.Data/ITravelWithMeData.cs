namespace TravelWithMe.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TravelWithMe.Data.Repositories;
    using TravelWithMe.Models;

    public interface ITravelWithMeData
    {
        IRepository<TravelWithMeUser> Users { get; }

        IRepository<Travel> Travels { get; }

        IRepository<City> Cities { get; }

        int SaveChanges();




    }
}
