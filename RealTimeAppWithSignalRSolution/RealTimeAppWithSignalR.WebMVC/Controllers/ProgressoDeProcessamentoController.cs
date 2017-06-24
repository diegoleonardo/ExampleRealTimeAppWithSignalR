using Microsoft.AspNet.SignalR;
using RealTimeAppWithSignalR.WebMVC.SignalR.Hubs;
using System.Diagnostics;
using System.Threading;
using System.Web.Mvc;

namespace RealTimeAppWithSignalR.WebMVC.Controllers
{
    public class ProgressoDeProcessamentoController : Controller
    {
        // GET: ProgressoDeProcessamento
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StartProcess(string connectionId)
        {
            Response.Expires = -1;
            var hub = GlobalHost.ConnectionManager.GetHubContext<ProgressBar>();
            Stopwatch stopWatch = Stopwatch.StartNew();

            for (int i = 1; i <= 100; i++)
            {
                hub.Clients.Client(connectionId).update(i);
                Thread.Sleep(150);
            }

            return Json(new { message = "Operação concluída." });
        }
    }
}