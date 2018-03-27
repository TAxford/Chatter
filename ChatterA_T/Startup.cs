using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterA_T.Startup))]
namespace ChatterA_T
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
