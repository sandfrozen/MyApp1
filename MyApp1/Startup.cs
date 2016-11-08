using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyApp1.Startup))]
namespace MyApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
