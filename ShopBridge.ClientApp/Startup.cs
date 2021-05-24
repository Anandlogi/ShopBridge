using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopBridge.ClientApp.Startup))]
namespace ShopBridge.ClientApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
