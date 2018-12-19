using Microsoft.Owin;
using Owin;
using System.Diagnostics;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app)
            Debug.WriteLine("Test commit3");
        }
    }
}
