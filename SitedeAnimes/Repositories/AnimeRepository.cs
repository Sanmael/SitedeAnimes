using Microsoft.EntityFrameworkCore;
using SitedeAnimes.Context;
using SitedeAnimes.Models;
using SitedeAnimes.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Repositories
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly AppDbContext _context;
        public AnimeRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Anime> Animes => _context.Animes.Include(g => g.Genero);
        public IEnumerable<Anime> AnimesPreferidos => _context.Animes.Where(a => a.IsAnimePreferido).Include(g => g.Genero);

        public Anime GetAnimeById(int animeId)
        {
            return _context.Animes.FirstOrDefault(a => a.AnimeId == animeId);
        }
    }
}
