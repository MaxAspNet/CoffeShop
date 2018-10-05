using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aprel.Startup))]
namespace Aprel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
