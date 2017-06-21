using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHELPLAB.Startup))]
namespace MVCHELPLAB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
