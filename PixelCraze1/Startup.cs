using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PixelCraze1.Startup))]
namespace PixelCraze1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
