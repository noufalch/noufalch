using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_2.Startup))]
namespace Demo_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
