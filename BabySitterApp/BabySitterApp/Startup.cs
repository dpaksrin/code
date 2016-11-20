using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BabySitterApp.Startup))]
namespace BabySitterApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
