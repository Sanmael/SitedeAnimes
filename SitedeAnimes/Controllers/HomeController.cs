using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SitedeAnimes.Models;
using SitedeAnimes.Repositories.Interfaces;
using SitedeAnimes.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnimeRepository _animeRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IAnimeRepository animeRepository, ILogger<HomeController> logger)
        {
            _animeRepository = animeRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                AnimesPreferidos = _animeRepository.AnimesPreferidos
            };
            return View(homeViewModel);
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
