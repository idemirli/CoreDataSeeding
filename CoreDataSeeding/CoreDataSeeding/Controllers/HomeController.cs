using CoreDataSeeding.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDataSeeding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; //added Comment

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string Deneme1 = string.Empty;
            string Deneme2 = string.Empty;
            string Deneme3 = string.Empty;
            string Deneme4 = string.Empty;
            string Deneme5 = string.Empty;
            string Deneme6 = string.Empty;
            string Deneme7 = string.Empty;
            string Deneme8 = string.Empty;
            string Deneme9 = string.Empty;
            string Deneme10 = string.Empty;
            string Deneme11 = string.Empty;
            string Deneme12 = string.Empty;
            string Deneme13 = string.Empty;
            string Deneme14 = string.Empty;
            string Deneme15 = string.Empty;
            return View();
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
