using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LojaWeb.Forms.Startup))]
namespace LojaWeb.Forms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
