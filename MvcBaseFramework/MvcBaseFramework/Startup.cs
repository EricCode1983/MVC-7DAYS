using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcBaseFramework.Startup))]
namespace MvcBaseFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
