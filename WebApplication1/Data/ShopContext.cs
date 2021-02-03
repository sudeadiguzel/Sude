
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace Data
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options)
    : base(options)
        { }


    }
}
