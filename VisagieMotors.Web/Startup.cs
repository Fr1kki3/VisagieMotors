using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisagieMotors.Web.Startup))]
namespace VisagieMotors.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
