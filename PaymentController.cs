using Microsoft.AspNetCore.Mvc;

namespace shopping.Controllers
{
    public class PaymentController : Controller
    {
        
        public IActionResult Options()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pay(string method)
        {
            ViewBag.Method = method;
            return View();
        }

        
        [HttpPost]
        public IActionResult Success(decimal amount)
        {
            if (amount <= 0)
            {
                TempData["Error"] = "Please enter a valid amount.";
                return RedirectToAction("Options");
            }

            ViewBag.Amount = amount;
            return View();
        }
    }
}
