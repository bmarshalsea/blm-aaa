using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HCMWeb.Startup))]
namespace HCMWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
