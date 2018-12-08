using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSEBookBank.Startup))]
namespace CSEBookBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
