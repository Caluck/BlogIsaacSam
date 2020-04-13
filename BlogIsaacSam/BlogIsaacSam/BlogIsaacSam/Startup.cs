using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogIsaacSam.Startup))]
namespace BlogIsaacSam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
