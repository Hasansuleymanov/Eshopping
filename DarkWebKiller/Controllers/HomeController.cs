using DarkWebKiller.Models;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics;

namespace DarkWebKiller.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeSliderService _slider;
        private readonly CollectionService _collection;

        public HomeController(ILogger<HomeController> logger, HomeSliderService slider, CollectionService collection)
        {
            _logger = logger;
            _slider = slider;
            _collection = collection;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM()
            {
                HomeSliders = _slider.GetAll(),
                Collections=_collection.GetAll(),
            };
            return View(vm);
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