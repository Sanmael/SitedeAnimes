using SitedeAnimes.Context;
using SitedeAnimes.Models;
using SitedeAnimes.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly AppDbContext _context;
        public GeneroRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Genero> Generos => _context.Generos;
    }
}
