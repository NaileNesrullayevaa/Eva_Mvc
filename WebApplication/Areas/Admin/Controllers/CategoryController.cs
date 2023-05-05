using EvaraWebbApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataContext;

namespace EvaraWebbApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly EvaraDbContext _evaraDbContext;

        public CategoryController(EvaraDbContext evaraDbContext)
        {
            _evaraDbContext = evaraDbContext;
        }
        [HttpGet]

        public async Task<IActionResult> Index()
        {   
            List<Category> categories= await _evaraDbContext.Categories.ToListAsync();
            return View(categories);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Category? category = await _evaraDbContext.Categories.FindAsync(id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category) { 
            if(!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

    }
}
