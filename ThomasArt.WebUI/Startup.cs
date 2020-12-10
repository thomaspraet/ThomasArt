using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThomasArt.WebUI.Startup))]
namespace ThomasArt.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
