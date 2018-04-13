using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TobChatWeb.Startup))]
namespace TobChatWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
