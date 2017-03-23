using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webSummator.Startup))]
namespace webSummator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
