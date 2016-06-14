using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCIntro2_20160614.Startup))]
namespace MVCIntro2_20160614
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
