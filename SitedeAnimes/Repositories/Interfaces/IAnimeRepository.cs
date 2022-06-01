using SitedeAnimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Repositories.Interfaces
{
    public interface IAnimeRepository
    {
        IEnumerable<Anime> Animes { get; }
        IEnumerable<Anime> AnimesPreferidos { get; }
        Anime GetAnimeById(int animeId);
    }
}
