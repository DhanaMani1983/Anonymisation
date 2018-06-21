using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Saga.GMD.Adobe.Anonymisation.WebUtility.Startup))]
namespace Saga.GMD.Adobe.Anonymisation.WebUtility
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
