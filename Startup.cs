using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedChartApp.Startup))]
namespace MedChartApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
