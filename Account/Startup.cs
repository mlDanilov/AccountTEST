using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Account.Startup))]
namespace Account
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
