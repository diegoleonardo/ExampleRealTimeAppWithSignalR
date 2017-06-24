using System.Web.Mvc;

namespace RealTimeAppWithSignalR.WebMVC.Controllers
{
    public class ExemploComHubsController : Controller
    {
        // GET: ExemploComHubs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MudarDeEstado()
        {
            return View();
        }
    }
}