using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mis42p2rd484215.Startup))]
namespace mis42p2rd484215
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
