using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Info_Net.Startup))]
namespace Info_Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
