using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsWeb.Startup))]
namespace SportsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
