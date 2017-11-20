using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NerdsOnWheels.Startup))]
namespace NerdsOnWheels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
