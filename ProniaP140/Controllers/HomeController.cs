using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaP140.DAL;
using ProniaP140.ViewModels;

namespace ProniaP140.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaDbContext _context;

        public HomeController(ProniaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Plants = _context.Plants.Include(p => p.PlantImages).ToList(),
                NewPlants=_context.Plants.OrderByDescending(x=>x.Id).Take(4).Include(x=>x.PlantImages).ToList(),
            };

            if (model.Sliders is null || model.Plants is null) return NotFound();

            return View(model);
        }
    }
}
