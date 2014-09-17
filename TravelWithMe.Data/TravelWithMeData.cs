namespace TravelWithMe.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using TravelWithMe.Data.Repositories;
    using TravelWithMe.Models;

    public class TravelWithMeData : ITravelWithMeData
    {
        private DbContext context;
        private IDictionary<Type, object> repositories;

        public TravelWithMeData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<TravelWithMeUser> Users
        {
            get
            {
                return this.GetRepository<TravelWithMeUser>();
            }
        }

        public IRepository<Travel> Travels
        {
            get
            {
                return this.GetRepository<Travel>();
            }
        }

        public IRepository<City> Cities
        {
            get
            {
                return this.GetRepository<City>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepository = typeof(T);
            if (this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(EfRepository<T>), context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>)this.repositories[typeOfRepository];
        }
    }
}
