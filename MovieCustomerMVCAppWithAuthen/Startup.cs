using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieCustomerMVCAppWithAuthen.Startup))]
namespace MovieCustomerMVCAppWithAuthen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
