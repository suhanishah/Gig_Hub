using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gig_Hub.Startup))]
namespace Gig_Hub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
