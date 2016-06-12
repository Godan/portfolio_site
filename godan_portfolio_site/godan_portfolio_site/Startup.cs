using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(godan_portfolio_site.Startup))]
namespace godan_portfolio_site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
