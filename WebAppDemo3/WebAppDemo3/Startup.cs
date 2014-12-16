using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppDemo3.Startup))]
namespace WebAppDemo3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
