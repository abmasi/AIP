using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIP.Startup))]
namespace AIP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
