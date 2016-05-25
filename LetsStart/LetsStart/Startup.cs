
using Microsoft.Owin;
using Owin;
[assembly: OwinStartupAttribute(typeof(LetsStart.Startup))]
namespace LetsStart
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}