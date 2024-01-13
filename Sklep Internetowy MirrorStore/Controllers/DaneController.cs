using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sklep_Internetowy_MirrorStore.Models;

namespace Sklep_Internetowy_MirrorStore.Controllers
{
    public class DaneController : Controller
    {
		[Authorize]
		public IActionResult Form()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Formualarz przesłany", dane);
            }
            else return View();
        }
        [Authorize]
        public IActionResult Wynik(Dane dane)
        {
            
            return View(dane);
        }

       
    }
}
