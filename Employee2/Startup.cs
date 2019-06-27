using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee2.Startup))]
namespace Employee2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
