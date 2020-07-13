using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KoalaTest2.Startup))]
namespace KoalaTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
