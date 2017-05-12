using Concert;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Startup))]
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
