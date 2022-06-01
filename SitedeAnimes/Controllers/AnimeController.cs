using Microsoft.AspNetCore.Mvc;
using SitedeAnimes.Repositories.Interfaces;
using SitedeAnimes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Controllers
{
    public class AnimeController : Controller
    {
        private readonly IAnimeRepository _animeRepository;
        public AnimeController(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }
        public IActionResult List()
        {
            //var animes = _animeRepository.Animes;
            //return View(animes);
            var animeListViewModel = new AnimeListViewModel();
            animeListViewModel.Animes = _animeRepository.Animes;
            animeListViewModel.GeneroAtual = "Categoria Atual";
            return View(animeListViewModel);
        }
    }
}
