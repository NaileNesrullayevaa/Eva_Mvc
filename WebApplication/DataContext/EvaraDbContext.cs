using EvaraWebbApp.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.DataContext
{
    public class EvaraDbContext:DbContext
    {
        public EvaraDbContext(DbContextOptions<EvaraDbContext> opt) : base(opt)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Color> Colors { get; set; }    
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
      
    }
}
