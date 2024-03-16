using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OLX_AspNet.Data;
using OLX_AspNet.Data.Entities;
using System.Data.Entity;

namespace OLX_AspNet.Controllers
{
    public class ItemsController : Controller
    {
        private readonly OLXDbContext context;

        public ItemsController(OLXDbContext context)
        {
            this.context = context;
        }
       
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(context.Categories.ToList(),nameof(Category.Id),nameof(Category.Name));
            return View();
        }
        public IActionResult Index()
        {
            var items = context.Items.Include(x=>x.Category).ToList(); //?

            return View();
        }
        [HttpPost]

        public IActionResult Create(Item model)
        {
            context.Items.Add(model);
            context.SaveChanges();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Item model)
        {
            if(!ModelState.IsValid) return View(model);
            context.Items.Update(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var item = context.Items.Find(id);
            if (item == null) return NotFound();

            context.Items.Remove(item);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
