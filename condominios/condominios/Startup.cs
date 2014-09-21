using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(condominios.Startup))]
namespace condominios
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
