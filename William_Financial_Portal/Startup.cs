using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(William_Financial_Portal.Startup))]
namespace William_Financial_Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
