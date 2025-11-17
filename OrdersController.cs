using Microsoft.AspNetCore.Mvc;

namespace shopping.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            var orders = new List<string>()
            {
                "Order #1001 - Atta 1kg - ₹50",
                "Order #1002 - Sugar 1kg - ₹45",
                "Order #1003 - Rice 1kg - ₹60"
            };

            return View(orders);
        }
    }
}
