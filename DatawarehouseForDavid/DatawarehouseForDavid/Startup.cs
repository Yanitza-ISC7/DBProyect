using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatawarehouseForDavid.Startup))]
namespace DatawarehouseForDavid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
