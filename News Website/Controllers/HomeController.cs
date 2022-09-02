using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using News_Website.Infrastructure;
using News_Website.Models;

namespace News_Website.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly NewsContext _context;

        public HomeController( NewsContext context)
        {
// _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        //get home/Contact
        public IActionResult Contact()
        {
            return View();
        }

        //post home/Contact
        [HttpPost]
        public async Task<IActionResult> Contact(ContactUs contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();

            return Redirect("Index");



        }


        public async Task<IActionResult> News(int id)
        {

            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            ViewBag.news = category;
            IEnumerable<News> news = await _context.News.Include(x=>x.Category).Where(x=>x.CategoryId == id).ToListAsync();

            return View(news);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
