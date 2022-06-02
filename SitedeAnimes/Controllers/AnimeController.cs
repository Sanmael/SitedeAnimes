using Microsoft.AspNetCore.Mvc;
using SitedeAnimes.Models;
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
        public IActionResult List(string genero)
        {
            IEnumerable<Anime> animes;
            string generoAtual = string.Empty;
            if (string.IsNullOrEmpty(genero))
            {
                animes = _animeRepository.Animes.OrderBy(a => a.AnimeId);
                generoAtual = "Todos os Animes";
            }
            else
            {
                //if (string.Equals("Ação", genero, StringComparison.OrdinalIgnoreCase))
                //{
                //    animes = _animeRepository.Animes.Where(a => a.Genero.Nome.Equals("Ação"))
                //        .OrderBy(a => a.Nome);
                //}
                //else
                //{
                //    animes = _animeRepository.Animes.Where(a => a.Genero.Nome.Equals("Aventura"))
                //       .OrderBy(a => a.Nome);
                //}
                animes = _animeRepository.Animes.Where(a => a.Genero.Nome.Equals(genero,StringComparison.OrdinalIgnoreCase)).OrderBy(g => g.Nome);
                generoAtual = genero;
            }
            var animeListViewModel = new AnimeListViewModel
            {
                Animes = animes,
                GeneroAtual = generoAtual
            };
            return View(animeListViewModel);
        }
        public IActionResult Details(int animeId)
        {
            var anime = _animeRepository.Animes.FirstOrDefault(a => a.AnimeId == animeId);
            return View(anime);
        }
        public ViewResult Search(string searchString)
        {
            IEnumerable<Anime> animes;
            string generoAtual = string.Empty;
            if (string.IsNullOrEmpty(searchString))
            {
                animes = _animeRepository.Animes.OrderBy(a => a.AnimeId);
                generoAtual = "Todos os Animes";
            }
            else
            {
                animes = _animeRepository.Animes.Where(a=> a.Nome.ToLower().Contains(searchString.ToLower()));
                if (animes.Any())
                    generoAtual = "Animes";
                else
                    generoAtual = "Nenhum anime foi encontrado";
            }
            return View("~/Views/Anime/List.cshtml", new AnimeListViewModel
            {
                Animes = animes,
                GeneroAtual = generoAtual
            });
        }
    }
}
