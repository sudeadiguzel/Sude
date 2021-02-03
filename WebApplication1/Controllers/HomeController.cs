using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController: Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IActionResult> Index(int? id, string q)
        {
            var products = await _productRepository.GetAll();

            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i => i.Name.ToLower().Contains(q.ToLower()) || i.Description.Contains(q.ToLower())).ToList();
            }
            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
