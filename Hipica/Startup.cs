using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hipica.Startup))]
namespace Hipica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
