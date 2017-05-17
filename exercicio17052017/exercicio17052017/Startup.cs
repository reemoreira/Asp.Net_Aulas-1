using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(exercicio17052017.Startup))]
namespace exercicio17052017
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
