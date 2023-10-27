using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sklep_Internetowy_MirrorStore.Models;
using System.Globalization;

namespace Sklep_Internetowy_MirrorStore.Controllers
{
    public class MirrorController : Controller
    {
        private static IList<Mirror> mirrors = new List<Mirror>
        {
            new Mirror(){Id = 1, Name = "Bloody Mirror", Description = "Idealne lustro na Halloween", Price = 199.99 , },
            new Mirror(){Id = 2, Name = "Flowers Mirror", Description = "Lustro ozdobione w sztuczne kwiatki", Price = 299.99,  },
            new Mirror(){Id = 3, Name = "Led Mirror", Description = "Lustro z paskiem led", Price = 399.99, }
        };

        // GET: ShopController
        public ActionResult Index()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            return View(mirrors);
        }

        // GET: ShopController/Details/5
        public ActionResult Details(int id)
        {
            return View(mirrors.FirstOrDefault(x => x.Id == id));
        }

        // GET: ShopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopController/Create/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Mirror mirror)
        {
            mirror.Id = mirrors.Count + 1;
            mirrors.Add(mirror);
            return RedirectToAction("Index");
        }


        // GET: ShopController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Mirror mirror)
        {
           Mirror mirror1 = mirrors.FirstOrDefault(x => x.Id == id);
            mirror1.Name = mirror.Name;
            mirror1.Description = mirror.Description;
            mirror1.Price = mirror.Price;

            return RedirectToAction("Index");
        }

        // GET: ShopController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(mirrors.FirstOrDefault(x => x.Id == id));
        }

        // POST: ShopController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Mirror mirror)
        {
            Mirror mirror1 = mirrors.FirstOrDefault(x => x.Id == id);

            mirrors.Remove(mirror1);
            return RedirectToAction("Index");
        }

        
        
    }
}
