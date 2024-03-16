using Microsoft.AspNetCore.Mvc;
using OLX_AspNet.Data;
using OLX_AspNet.Models;
using System.Data.Entity;
using System.Diagnostics;

namespace OLX_AspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OLXDbContext context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var items = context.Items.Include(x => x.Category).ToList();
            return View(items);
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
    }
}