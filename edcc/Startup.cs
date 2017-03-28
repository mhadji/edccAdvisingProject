using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(edcc.Startup))]
namespace edcc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
