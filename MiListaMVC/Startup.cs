using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiListaMVC.Startup))]
namespace MiListaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
