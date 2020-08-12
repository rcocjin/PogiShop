using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PogiShop.WebUI.Startup))]
namespace PogiShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
