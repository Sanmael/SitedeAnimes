
using System.ComponentModel.DataAnnotations;

namespace SitedeAnimes.Models
{
    public class Anime
    {
        public int AnimeId { get; set; }
        [Required(ErrorMessage ="O nome do Anime deve ser informado!")]
        [Display(Name = "Nome do Anime")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição do Anime deve ser informado!")]
        [Display(Name = "Descrição do Anime")]
        public string Descricao { get; set; }
        [Display(Name ="Quantidade De Episodios")]
        public double NumeroDeEpisodios { get; set; }
        [Display(Name = "Quantidade De Temporadas")]
        public int NumeroDeTemporadas { get; set; }
        [Display(Name = "Nome Do Diretor")]
        public string  NomeDoDiretor { get; set; }
        [Display(Name = "Data de Lançamento")]
        public string AnoDeLancamento { get; set; }

        [Display(Name = "Imagem Thumbnail")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Imagem Banner")]
        public string ImagemUrlPagina { get; set; }
        [Display(Name = "Anime Preferido?")]
        public bool IsAnimePreferido { get; set; }
        [Required(ErrorMessage = "A Nota do Anime deve ser informado!")]
        [Display(Name = "Nota do Anime")]
        public int Nota { get; set; }
        [Required(ErrorMessage = "O Link para ver o Anime deve ser informado!")]
        [Display(Name = "Site do Anime")]
        public string SiteAssistirAnime { get; set; }
        [Display(Name = "Genero do Anime")]
        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }

    }
}
