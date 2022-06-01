using SitedeAnimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Repositories.Interfaces
{
    public interface IGeneroRepository
    {
        IEnumerable<Genero> Generos { get; }

    }
}
