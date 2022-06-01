
using System.ComponentModel.DataAnnotations;

namespace SitedeAnimes.Models
{
    public class Anime
    {
        [Key]
        public int AnimeId { get; set; }
        [Required(ErrorMessage ="O nome do Anime deve ser informado!")]
        [Display(Name = "Nome do Anime")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição do Anime deve ser informado!")]
        [Display(Name = "Descrição do Anime")]
        [MinLength(200),MaxLength(1000,ErrorMessage ="Minimo de 200 caracteres, maximo de 1000")]
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
        public bool IsAnimePreferido { get; set; }
        [Required(ErrorMessage = "A Nota do Anime deve ser informado!")]
        [Display(Name = "Nota do Anime")]
        public int Nota { get; set; }
        [Required(ErrorMessage = "O Link para ver o Anime deve ser informado!")]
        [Display(Name = "Site do Anime")]
        public string SiteAssistirAnime { get; set; }
        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }

    }
}
