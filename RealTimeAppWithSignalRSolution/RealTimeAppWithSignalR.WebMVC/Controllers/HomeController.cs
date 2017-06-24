using Microsoft.AspNet.SignalR;
using RealTimeAppWithSignalR.WebMVC.SignalR.Hubs;
using RealTimeAppWithSignalR.WebMVC.SignalR.PersistentConnections;
using System;
using System.Web.Mvc;

namespace RealTimeAppWithSignalR.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private static IPersistentConnectionContext connSpy = GlobalHost.ConnectionManager.GetConnectionContext<SpyConnection>();
        private static IHubContext hubLogAcesso = GlobalHost.ConnectionManager.GetHubContext<LogDeAcessoHome>();

        public ActionResult Index()
        {
            var message = $"{DateTime.Now.ToShortTimeString()}: Request para '{Request.Url.ToString()}' Do IP {Request.UserHostAddress} usando {Request.Browser.Type}";
            
            connSpy.Connection.Broadcast(message);
            hubLogAcesso.Clients.All.novoAcesso(message);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}