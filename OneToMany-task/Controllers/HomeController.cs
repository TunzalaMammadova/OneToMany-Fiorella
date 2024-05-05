using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;
using OneToMany_task.Models;
using OneToMany_task.ViewModels;

namespace OneToMany_task.Controllers
{
	public class HomeController : Controller
	{

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo? sliderInfo = await _context.SliderInfos.FirstAsync();

      
            HomeVM model = new()
            {
                Sliders = sliders,
                
            };

            return View(model);
        }
    }
}

