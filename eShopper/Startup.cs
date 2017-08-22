using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eShopper.Startup))]
namespace eShopper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
