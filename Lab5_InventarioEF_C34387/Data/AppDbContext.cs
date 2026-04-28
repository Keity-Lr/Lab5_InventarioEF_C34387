using Lab5_InventarioEF_C34387.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5_InventarioEF_C34387.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
