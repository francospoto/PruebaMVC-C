using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaMVC_C.Startup))]
namespace PruebaMVC_C
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
