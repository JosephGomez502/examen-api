
using Microsoft.EntityFrameworkCore;
using ExamenAPI.Models;

namespace ExamenAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
