using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventHubApp.Startup))]
namespace EventHubApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
