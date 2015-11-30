using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoiveTime.Startup))]
namespace MoiveTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
