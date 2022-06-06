using SitedeAnimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Anime> AnimesPreferidos { get; set; }
    }
}
