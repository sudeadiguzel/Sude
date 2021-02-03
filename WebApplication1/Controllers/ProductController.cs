using Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository; 

        public ProductController(IProductRepository productRepository)
        {
             _productRepository = productRepository;
        }
        public async Task<IActionResult> List(int? id,string q)
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
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productRepository.GetById(id);
            return View(product);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(new Product());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)    
        {
            if (ModelState.IsValid)
            {
                await _productRepository.Create(product); //sıkıntı çıkarsa int değere ata
               
                return RedirectToAction("List"); //go to List method
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(product);
        }
        
        //private ProductViewModel ProductToProductViewModel(Product product)
        //{
        //    var productModel=new ProductViewModel();
        //    productModel.Products.Add(product);
        //    return productModel;
        //}
        //#endregion
    }
}