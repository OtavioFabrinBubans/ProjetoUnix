using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnixsGeradorDeProvas.Startup))]
namespace UnixsGeradorDeProvas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
