using System;
using Microsoft.EntityFrameworkCore;
using eCommerce.Models;

namespace eCommerce.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ViewInfo> ViewInfo { get; set; }
    }
}