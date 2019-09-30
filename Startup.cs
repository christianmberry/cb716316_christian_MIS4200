using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cb716316_christian_MIS4200.Startup))]
namespace cb716316_christian_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
