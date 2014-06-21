using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisualScotParliament.Web.Startup))]
namespace VisualScotParliament.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
