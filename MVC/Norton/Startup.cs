using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Norton.Startup))]
namespace Norton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
