using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azure_sandbox.Startup))]
namespace azure_sandbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
