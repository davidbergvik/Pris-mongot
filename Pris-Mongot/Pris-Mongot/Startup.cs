using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pris_Mongot.Startup))]
namespace Pris_Mongot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
