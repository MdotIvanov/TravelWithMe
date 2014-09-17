using Microsoft.Owin;

using TravelWithMe.Service;

[assembly: OwinStartup(typeof(Startup))]

namespace TravelWithMe.Service
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}