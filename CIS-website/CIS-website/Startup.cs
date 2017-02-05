using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIS_website.Startup))]
namespace CIS_website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
