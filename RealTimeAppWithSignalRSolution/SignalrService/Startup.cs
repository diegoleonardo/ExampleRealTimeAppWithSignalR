using Microsoft.Owin.Cors;
using Owin;

namespace SignalrService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll).MapSignalR();
        }
    }
}
