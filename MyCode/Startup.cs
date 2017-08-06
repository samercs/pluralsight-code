using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCode.Startup))]
namespace MyCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
