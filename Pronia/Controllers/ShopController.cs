using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DAL;
using Pronia.Entities;

namespace Pronia.Controllers
{
    public class ShopController:Controller
    {
        readonly ProniaDbContext _context;

        public ShopController(ProniaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Plant> plant = _context.Plants.Include(i=>i.PlantImages).ToList();
            return View(plant);
        }
        public IActionResult Details(int id)
        {
            if (id == 0) return NotFound();
            Plant? plant = _context.Plants
               .Include(b=>b.PlantCategories).ThenInclude(pt => pt.Category)
                .Include(b=>b.PlantTags).ThenInclude(bt => bt.Tag)
                 .Include(p=>p.PlantDeliveryInformation).Include(p=>p.PlantImages)
                  .Where(x => x.Id == id)
                   .FirstOrDefault(b=>b.Id==id);
            return View(plant);
        }
    }
}
