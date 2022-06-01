using Microsoft.EntityFrameworkCore;
using SitedeAnimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Anime> Animes { get; set; }
    }
}
