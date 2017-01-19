using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCGLounge2.Startup))]
namespace TCGLounge2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
