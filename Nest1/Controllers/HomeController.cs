using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest1.DAL;
using Nest1.Models;
using Nest1.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest1.Controllers
{
    public class HomeController:Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IQueryable<Product> query = _context.Products.Include(p => p.ProductImages).Include(p => p.Category).AsQueryable();
            HomeVM homeVM = new HomeVM()
            {
                Sliders= await _context.Sliders.ToListAsync(),
                Categories= await _context.Categories.ToListAsync(),
                Products= await _context.Products.Include(p=>p.ProductImages).Include(p=>p.Category).Take(10).ToListAsync(),
                RecentProducts = await query.OrderByDescending(p => p.Id).Take(3).ToListAsync()
            };
            
            return View(homeVM);
        }
       
    }
}
