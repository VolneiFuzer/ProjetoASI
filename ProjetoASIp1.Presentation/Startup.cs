using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoASIp1.Presentation.Startup))]
namespace ProjetoASIp1.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
