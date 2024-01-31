using EFCore_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_CodeFirst.Controllers
{
    public class BrandController : Controller
    {
        private CompanyDBContext _db;
        public BrandController(CompanyDBContext db)
        {
            _db = db;
        }
        [Route("brands")]
        public IActionResult Index()
        {
          
           List<Brand> brands = _db.Brands.ToList();
            return View(brands);
        }
    }
}
