using GroupMap.Service;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupMap.Startup))]
namespace GroupMap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            AutoMapperConfig.Initialize();
        }
    }
}
