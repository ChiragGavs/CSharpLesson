using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NWindMVCApp.Models;

namespace NWindMVCApp.Controllers
{
    public class OrderController : Controller
    {
        private RepositoyOrder _context;
        public OrderController(RepositoyOrder context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<int> order = _context.GetAllOrder();
            OrderIdViewModel idViewModel = new OrderIdViewModel(order);
            return View(idViewModel);
        }
        public IActionResult Details(int id)
        {
            Order order = _context.PutOrder(id);
            return View(order);
        }
        public IActionResult ProductDetails(int id)
        {
            Product product = _context.GetProductById(id);
            return View(product);
        }
        public IActionResult SearchProductDetails()
        {
            Dictionary<int, string> products = _context.GetallProductId();
            ViewBag.ProductId = new SelectList(products, "Key", "Value");
            return View(products);
        }
 
    }

}
