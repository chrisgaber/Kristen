using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kristen.com.Startup))]
namespace Kristen.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
