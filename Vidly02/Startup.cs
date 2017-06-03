using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly02.Startup))]
namespace Vidly02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
