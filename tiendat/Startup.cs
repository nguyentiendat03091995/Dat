using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tiendat.Startup))]
namespace tiendat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
