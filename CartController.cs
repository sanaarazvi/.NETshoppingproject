using Microsoft.AspNetCore.Mvc;
using shopping.Data;
using shopping.Models;

namespace shopping.Controllers
{
    public class CartController : Controller
    {
        
        private static readonly List<CartItem> Cart = new();

        public IActionResult Add(int id)
        {
            var product = ProductStore.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                var existing = Cart.FirstOrDefault(c => c.Product.Id == id);
                if (existing != null) existing.Quantity++;
                else Cart.Add(new CartItem { Product = product, Quantity = 1 });
            }
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(Cart);
        }

        public IActionResult Remove(int id)
        {
            var item = Cart.FirstOrDefault(c => c.Product.Id == id);
            if (item != null) Cart.Remove(item);
            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            Cart.Clear();
            return RedirectToAction("Index");
        }

        
        public IActionResult BuyNow()
        {
            return RedirectToAction("Options", "Payment");
        }
    }
}
