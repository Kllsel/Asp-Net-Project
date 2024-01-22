using Microsoft.AspNetCore.Mvc;
using OLX_AspNet.Data;

namespace OLX_AspNet.Controllers
{
    public class ItemsController : Controller
    {
        private readonly OLXDbContext context;

        public ItemsController(OLXDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var items = context.Items.ToList();

            return View(items);
        }
    }
}
