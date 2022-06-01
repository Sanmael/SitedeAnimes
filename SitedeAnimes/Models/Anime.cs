
namespace SitedeAnimes.Models
{
    public class Anime
    {
        public int AnimeId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
        public bool IsAnimePreferido { get; set; }
        public int Nota { get; set; }
        public string SiteAssistirAnime { get; set; }
        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }

    }
}
