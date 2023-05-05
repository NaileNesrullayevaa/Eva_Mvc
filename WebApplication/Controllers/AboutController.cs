using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataContext;

namespace EvaraWebbApp.Controllers
{
    public class AboutController : Controller
    {
        public readonly EvaraDbContext _dbContext;
        public AboutController(EvaraDbContext evaraDbContext)
        {
            evaraDbContext = _dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
