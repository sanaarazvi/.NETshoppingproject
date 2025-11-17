using shopping.Models;

namespace shopping.Data
{
    public static class ProductStore
    {
        public static List<Product> Products { get; } = new List<Product>
        {
            new Product { Id=1, Title="Sugar 1kg", Price=45, ImageUrl="/images/sugar.jpg"},
            new Product { Id=2, Title="Atta 5kg", Price=220, ImageUrl="/images/atta.jpg"},
            new Product { Id=3, Title="Rice 5kg", Price=340, ImageUrl="/images/rice.jpg"},
            new Product { Id=4, Title="Cooking Oil 1L", Price=170, ImageUrl="/images/oil.jpg"},
            new Product { Id=5, Title="Salt 1kg", Price=60, ImageUrl="/images/salt.jpg"},
            new Product { Id=6, Title="Tea 250g", Price=120, ImageUrl="/images/tea.jpg"},
            new Product { Id=7, Title="Coffee 200g", Price=200, ImageUrl="/images/coffee.jpg"},
            new Product { Id=8, Title="Biscuits Pack", Price=40, ImageUrl="/images/biscuits.jpg"},
            new Product { Id=9, Title="Soap Bar", Price=35, ImageUrl="/images/soap.jpg"},
            new Product { Id=10, Title="Shampoo 200ml", Price=150, ImageUrl="/images/shampoo.jpg"},
            new Product { Id=11, Title="Toothpaste", Price=80, ImageUrl="/images/toothpaste.jpg"},
            new Product { Id=12, Title="Detergent 1kg", Price=160, ImageUrl="/images/detergent.jpg"},
            new Product { Id=13, Title="Milk 1L (UHT)", Price=60, ImageUrl="/images/milk.jpg"},
            new Product { Id=14, Title="Eggs (6 pcs)", Price=70, ImageUrl="/images/eggs.jpg"},
            new Product { Id=15, Title="Paneer 200g", Price=90, ImageUrl="/images/paneer.jpg"},
            new Product { Id=16, Title="Fresh Vegetables Pack", Price=120, ImageUrl="/images/veg.jpg"},
            new Product { Id=17, Title="Fresh Fruits Pack", Price=140, ImageUrl="/images/fruits.jpg"},
            new Product { Id=18, Title="Salted Chips", Price=30, ImageUrl="/images/chips.jpg"},
            new Product { Id=19, Title="Cold Drink 1.5L", Price=110, ImageUrl="/images/cola.jpg"},
            new Product { Id=20, Title="Chocolate Bar", Price=50, ImageUrl="/images/chocolate.jpg"},
            new Product { Id=21, Title="Instant Noodles", Price=25, ImageUrl="/images/noodles.jpg"},
            new Product { Id=22, Title="Ketchup Bottle", Price=95, ImageUrl="/images/ketchup.jpg"},
            new Product { Id=23, Title="Mustard Sauce", Price=85, ImageUrl="/images/mustard.jpg"},
            new Product { Id=24, Title="Cooking Masala", Price=130, ImageUrl="/images/masala.jpg"},
            new Product { Id=25, Title="perfume ", Price=199, ImageUrl="/images/spray.jpg"}
        };
    }
}
