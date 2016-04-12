using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MailProject.Startup))]
namespace MailProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
