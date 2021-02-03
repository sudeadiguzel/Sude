using Data;
using Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ProductRepository: IProductRepository
    {
        private static ShopContext _shopContext = null;
        public static List<Product> _products=new List<Product>();
        public ProductRepository(ShopContext context)
        {
            //_products = new List<Product>();
            
            //{
            //    new Product {ProductId=1, Name = "Iphone 7", Price = 2000, Description = "Old Iphone" ,IsApproved=false, ImageUrl="1.jpg", CategoryId=1},
            //    new Product {ProductId=2, Name = "Iphone 8", Price = 3000, Description = "Iphone",IsApproved=true, ImageUrl="2.jpg",CategoryId=1}, 
            //    new Product {ProductId=3, Name = "Iphone 11", Price = 8000, Description = "New Iphone", IsApproved=true, ImageUrl="3.jpg",CategoryId=1},
            //    new Product {ProductId=4, Name = "Lenova", Price = 2000, Description = "Old Iphone" ,ImageUrl="1.jpg", CategoryId=2},
            //    new Product {ProductId=5, Name = "HP", Price = 3000, Description = "Iphone",ImageUrl="2.jpg",CategoryId=2},
            //    new Product {ProductId=6, Name = "Samsung", Price = 8000, Description = "New Iphone",IsApproved=false, ImageUrl="3.jpg",CategoryId=2},
            //    new Product {ProductId=7, Name = "Refrigerator", Price = 2000, Description = "Old Iphone" ,IsApproved=true, ImageUrl="1.jpg", CategoryId=3},
            //    new Product {ProductId=8, Name = "Washing Machine", Price = 3000, Description = "Iphone",IsApproved=true, ImageUrl="2.jpg",CategoryId=3},
            //    new Product {ProductId=9, Name = "Iron", Price = 8000, Description = "New Iphone",ImageUrl="3.jpg",CategoryId=3}
            //};
            _shopContext = context;
        }

        public async Task<int> AddProduct(Product product)
        {
            var newProduct = new Product()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                IsApproved = product.IsApproved,
                ImageUrl = product.ImageUrl,
                CategoryId=product.CategoryId
            };
            await _shopContext.Products.AddAsync(newProduct);
            await _shopContext.SaveChangesAsync();

            return newProduct.ProductId;
        }

        public async Task<Product> GetById(int id)
        {
            return await _shopContext.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _shopContext.Products.ToListAsync();
        }

        public async Task Create(Product product)
        {
            var newProduct = new Product()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                IsApproved = product.IsApproved,
                ImageUrl = product.ImageUrl,
                CategoryId = product.CategoryId
            };
            await _shopContext.Products.AddAsync(newProduct);
            await _shopContext.SaveChangesAsync();
        }

        public async Task Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
