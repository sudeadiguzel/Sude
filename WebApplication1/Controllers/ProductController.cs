using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {

            var category1 = new Category { Name = "Phone", Description = "In Sale" };
            var category2 = new Category { Name = "Phone", Description = "In Sale" };

            var products = new List<Product>()
            {
                new Product { Name = "Iphone 8", Price = 3000, Description = "Iphone", Category = category1 },
                new Product { Name = "Iphone 11", Price = 8000, Description = "New Iphone", Category = category2 }
            };


            var productViewModels = new List<ProductViewModel>();

            foreach(var product in products)
            {
                var productViewModel = ProductToProductViewModel(product);
                productViewModels.Add(productViewModel);
            }
        

            return View(productViewModels);
        }
        public IActionResult Details()
        {
            ////ViewBag.Name = "Samsung s6";
            ////ViewBag.Price = "600";
            ////ViewBag.Description = "Android phone";

            //var p = new Product();
            //p.SetName("Samsung S6");
            //p.SetPrice(600);
            //p.SetDescription("Android Phone");

            return View();
        }

        #region Mapper Methods
        private ProductViewModel ProductToProductViewModel(Product product)
        {
            return new ProductViewModel
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryName = product.Category.Name
            };
        }
        #endregion
    }
}
