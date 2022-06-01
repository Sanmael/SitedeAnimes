using SitedeAnimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.ViewModels
{
    public class AnimeListViewModel
    {
        public IEnumerable<Anime> Animes { get; set; }
        public string GeneroAtual { get; set; }
    }
}
