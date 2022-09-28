using AspDotNetCoreE_Commerce.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspDotNetCoreE_Commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.ProductTypes.ToList();
            return View(data);
        }
    }
}
