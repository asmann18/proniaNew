using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaP140.DAL;
using ProniaP140.Entities;
using ProniaP140.ViewModels;

namespace ProniaP140.Controllers
{
    public class PlantsController : Controller
    {
        private readonly ProniaDbContext _context;

        public PlantsController(ProniaDbContext context)
        {
            _context = context;
        }

        public IActionResult Details(int id)
        {
            if (id < 0) return BadRequest();
            Plant? plant = _context.Plants.Include(p => p.PlantImages).Include(x => x.PlantTags).ThenInclude(x => x.Tag).Include(x => x.PlantCategories).ThenInclude(x => x.Category).Include(x => x.PlantInformations).ThenInclude(x => x.Information).FirstOrDefault(p => p.Id == id);
            if (plant == null)
                return NotFound();

            var PC = _context.PlantCategories.Where(x => x.CategoryId == plant.PlantCategories.FirstOrDefault().CategoryId).Include(x=>x.Plant).ThenInclude(x=>x.PlantImages).ToList();

            List<Plant> relatedPlants = new();
            foreach (var item in PC)
            {
                relatedPlants.Add(item.Plant);
            }

            DetailVM vm = new() { Plant = plant, RelatedPlants = relatedPlants} ;
            return View(vm);
        }
    }
}
