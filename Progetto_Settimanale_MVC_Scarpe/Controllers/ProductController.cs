using Microsoft.AspNetCore.Mvc;
using Progetto_Settimanale_MVC_Scarpe.Models;

namespace Progetto_Settimanale_MVC_Scarpe.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductRepository.Products;
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
