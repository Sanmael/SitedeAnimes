﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nome { get; set; }
        public List<Anime> Animes { get; set; }

    }
}
