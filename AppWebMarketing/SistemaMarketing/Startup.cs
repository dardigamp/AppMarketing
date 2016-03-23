using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaMarketing.Startup))]
namespace SistemaMarketing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
