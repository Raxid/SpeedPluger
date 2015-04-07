using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpeedPluger.Startup))]
namespace SpeedPluger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
