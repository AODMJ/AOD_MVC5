using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AOD_MVC5.Startup))]
namespace AOD_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
