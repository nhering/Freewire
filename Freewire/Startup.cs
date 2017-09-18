using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Freewire.Startup))]
namespace Freewire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
