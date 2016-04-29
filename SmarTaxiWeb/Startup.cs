using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmarTaxiWeb.Startup))]
namespace SmarTaxiWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
