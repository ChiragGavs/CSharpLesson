using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SampleA : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult start() { return View(); }
    }
}
