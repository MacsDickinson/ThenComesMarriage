using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ThenComesMarriage.Startup))]

namespace ThenComesMarriage
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
