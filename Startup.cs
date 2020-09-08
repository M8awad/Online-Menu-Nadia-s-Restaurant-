using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Menu.Startup))]
namespace E_Menu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
