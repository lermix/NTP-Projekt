using Microsoft.AspNetCore.Mvc;

namespace CentralniServer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["RequestTestExample"] = RequestTest();
            return View();
        }

        public string RequestTest()
        {
            return "OK";
        }
    }
}
