using System.Web.Mvc;

namespace RealTimeAppWithSignalR.WebMVC.Controllers
{
    public class DrawingBoardController : Controller
    {
        // GET: DrawingBoard
        public ActionResult Index()
        {
            return View();
        }
    }
}