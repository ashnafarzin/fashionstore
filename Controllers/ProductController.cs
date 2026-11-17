
using Microsoft.AspNetCore.Mvc;
using FashionStore.Models;

namespace FashionStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Creating product list

            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Floral Dress",
                    Price = 1299,
                    Description = "Beautiful floral summer dress",
                    ImageUrl = "/images/floral.jpg",
                    Category = "Casual Wear",
                    IsAvailable = true
                },

                new Product()
                {
                    Id = 2,
                    Name = "Party Wear Dress",
                    Price = 1799,
                    Description = "Elegant party wear dress",
                    ImageUrl = "/images/floral.jpg",
                    Category = "Party Wear",
                    IsAvailable = true
                },

                new Product()
                {
                    Id = 3,
                    Name = "Casual Dress",
                    Price = 999,
                    Description = "Comfortable daily wear dress",
                    ImageUrl = "/images/denim.avif",
                    Category = "Casual Wear",
                    IsAvailable = true
                }
            };

            return View(products);
        }
    }
}
