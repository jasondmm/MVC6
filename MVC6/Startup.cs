using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC6.Startup))]
namespace MVC6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
