using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieTime.Startup))]
namespace MovieTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
