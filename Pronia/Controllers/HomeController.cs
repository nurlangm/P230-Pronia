using Microsoft.AspNetCore.Mvc;
using Pronia.DAL;
using Pronia.Entities;
using System.Diagnostics;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        readonly ProniaDbContext _context;

        public HomeController(ProniaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider>slider=_context.Sliders.ToList();
            return View(slider);
        }
    }
}