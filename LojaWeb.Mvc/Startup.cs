using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LojaWeb.Mvc.Startup))]
namespace LojaWeb.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
