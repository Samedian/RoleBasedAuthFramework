using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleBasedAuthFramework.Startup))]
namespace RoleBasedAuthFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
