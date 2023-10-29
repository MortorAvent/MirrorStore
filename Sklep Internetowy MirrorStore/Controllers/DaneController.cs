using Microsoft.AspNetCore.Mvc;
using Sklep_Internetowy_MirrorStore.Models;

namespace Sklep_Internetowy_MirrorStore.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();
        }
        public IActionResult Wynik(Dane dane)
        {

            return View(dane);
        }

       
    }
}
