using Owin;
using Microsoft.Owin.Cors;

namespace RealTimeApp.WindowsServiceApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll).MapSignalR();
        }
    }
}
