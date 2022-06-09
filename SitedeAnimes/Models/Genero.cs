using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        [Required(ErrorMessage = "O Nome do genero deve ser informado!")]
        [Display(Name = "Nome do genero")]
        public string Nome { get; set; }
        public List<Anime> Animes { get; set; }

    }
}
