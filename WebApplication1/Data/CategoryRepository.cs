using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class CategoryRepository
    {
        //private static ShopContext _shopContext = null;
        private static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category { CategoryId=1, Name = "Phone", Description = "In Sale" },
                new Category { CategoryId=2, Name = "Computer", Description = "In Sale" },
                new Category { CategoryId=3, Name = "Electronic", Description = "In Sale" }
        };
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategorybyId(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
