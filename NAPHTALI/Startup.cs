using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NAPHTALI.Startup))]
namespace NAPHTALI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
