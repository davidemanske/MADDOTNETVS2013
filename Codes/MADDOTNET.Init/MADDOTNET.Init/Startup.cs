using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MADDOTNET.Init.Startup))]
namespace MADDOTNET.Init
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
