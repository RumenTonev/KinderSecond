using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KinderSecond.Startup))]
namespace KinderSecond
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
