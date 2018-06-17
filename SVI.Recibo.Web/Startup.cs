using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SVI.Recibo.Web.Startup))]
namespace SVI.Recibo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
