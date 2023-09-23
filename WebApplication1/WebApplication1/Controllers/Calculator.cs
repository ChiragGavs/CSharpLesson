using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Calculator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Add(int x , int y)
        {
            return x + y;
        }
    }
}
