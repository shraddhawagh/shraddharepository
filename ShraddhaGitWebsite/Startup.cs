using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShraddhaGitWebsite.Startup))]
namespace ShraddhaGitWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
