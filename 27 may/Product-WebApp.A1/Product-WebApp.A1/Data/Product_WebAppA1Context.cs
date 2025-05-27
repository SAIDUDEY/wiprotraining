using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product_WebApp.A1.Models;

namespace Product_WebApp.A1.Data
{
    public class Product_WebAppA1Context : DbContext
    {
        public Product_WebAppA1Context (DbContextOptions<Product_WebAppA1Context> options)
            : base(options)
        {
        }

        public DbSet<Product_WebApp.A1.Models.Product> Product { get; set; } = default!;
    }
}
