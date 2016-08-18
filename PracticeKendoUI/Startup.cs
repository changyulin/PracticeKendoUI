using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeKendoUI.Startup))]
namespace PracticeKendoUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
