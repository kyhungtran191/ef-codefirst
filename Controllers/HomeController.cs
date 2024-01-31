using EFCore_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EFCore_CodeFirst.Controllers
{
    public class HomeController : Controller
    {

      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}