using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(parentComp.Startup))]
namespace parentComp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
