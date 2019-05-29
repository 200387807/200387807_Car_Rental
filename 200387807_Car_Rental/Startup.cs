using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200387807_Car_Rental.Startup))]
namespace _200387807_Car_Rental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
