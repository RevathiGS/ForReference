using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthCareAppointment.Startup))]
namespace HealthCareAppointment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
