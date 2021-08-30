using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SisPicWEB.Startup))]
namespace SisPicWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
