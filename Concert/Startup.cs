using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Concert.Startup))]
namespace Concert
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
