using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumerologyCalculator.Startup))]
namespace NumerologyCalculator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
