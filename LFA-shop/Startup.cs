using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFA_shop.Startup))]
namespace LFA_shop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
