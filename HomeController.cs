using Microsoft.AspNetCore.Mvc;
using shopping.Data;

namespace shopping.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductStore.Products);
        }
    }
}
