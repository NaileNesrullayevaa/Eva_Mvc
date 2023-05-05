using EvaraWebbApp.Models;
using EvaraWebbApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApplication1.DataContext;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {   
        private readonly EvaraDbContext _dbContext;
        public HomeController(EvaraDbContext evaraDbContext)
        {
           _dbContext = evaraDbContext;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _dbContext.Categories.Include(c => c.Products).ToListAsync();
            List<Product> products = await _dbContext.Products.Include(c => c.Category).ToListAsync();
            List<Slider> sliders = await _dbContext.Sliders.ToListAsync();

            HomeVM homeVM = new HomeVM()
            {
                Products = products,
                Sliders = sliders,
            };
            return View(homeVM);
        }
       
    }
}
