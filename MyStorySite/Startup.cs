using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyStorySite.Startup))]
namespace MyStorySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
