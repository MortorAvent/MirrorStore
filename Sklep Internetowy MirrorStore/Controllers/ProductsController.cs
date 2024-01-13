using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sklep_Internetowy_MirrorStore.Areas.Identity.Data;

namespace Sklep_Internetowy_MirrorStore.Controllers
{
    public class ProductsController : Controller
    {

        private readonly MirrorStoreDbContext _context;

        public ProductsController(MirrorStoreDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            return View();
        }
    }
}


