using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanoB.Startup))]
namespace PlanoB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
