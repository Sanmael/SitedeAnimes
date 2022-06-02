using SitedeAnimes.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SitedeAnimes.Components
{
    public class GeneroMenu : ViewComponent
    {
        private readonly IGeneroRepository _generoRepository;
        public GeneroMenu(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }
        public IViewComponentResult Invoke()
        {
            var generos = _generoRepository.Generos.OrderBy(g=> g.Nome);
            return View(generos);
        }
    }
}
