using System.Web.Mvc;

namespace RealTimeAppWithSignalR.WebMVC.Controllers
{
    public class LogDaHomeController : Controller
    {
        // GET: LogDaHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AcessaComConexaoPersistente()
        {
            return View();
        }

        public ActionResult AcessaComHubs()
        {
            return View();
        }
    }
}