using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plano_C.Startup))]
namespace Plano_C
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
