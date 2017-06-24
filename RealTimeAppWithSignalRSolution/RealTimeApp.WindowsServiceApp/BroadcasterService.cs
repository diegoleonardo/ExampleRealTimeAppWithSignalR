using Microsoft.Owin.Hosting;
using System;
using System.ServiceProcess;

namespace RealTimeApp.WindowsServiceApp
{
    public class BroadcasterService: ServiceBase
    {
        private IDisposable _webApp;
        public BroadcasterService()
        {
            //InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            var address = (args != null && args.Length > 0)
            ? args[0]
            : "http://localhost:54321";
            _webApp = WebApp.Start<Startup>(address);
        }
        protected override void OnStop()
        {
            _webApp.Dispose();
        }
    }
}
