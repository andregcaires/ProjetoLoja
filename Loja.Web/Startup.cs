using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Loja.Web.Startup))]
namespace Loja.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
