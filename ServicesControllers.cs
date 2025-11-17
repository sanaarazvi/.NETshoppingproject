using Microsoft.AspNetCore.Mvc;

namespace shopping.Controllers
{
    public class ServicesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string complaintText)
        {
            TempData["Message"] = "Complaint Submitted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
