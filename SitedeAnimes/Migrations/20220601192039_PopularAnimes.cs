using Microsoft.EntityFrameworkCore.Migrations;

namespace SitedeAnimes.Migrations
{
    public partial class PopularAnimes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Animes(Nome,Descricao,ImagemUrl,IsAnimePreferido,Nota,SiteAssistirAnime,GeneroId)" +
                " VALUES('Shingeki No Kyojin','Shingeki no Kyojin (進撃の巨人?) também conhecido como Attack on Titan, é uma série de mangá escrita e ilustrada por Hajime Isayama. É ambientado em um mundo onde a humanidade vive dentro de cidades cercadas por três enormes muralhas que os protegem dos gigantescos humanóides devoradores de humanos chamados de Titãs; a história segue Eren Yeager, que jura exterminar os Titãs após um Titã causar a destruição de sua cidade natal e a morte de sua mãe. Shingeki no Kyojin teve seus capítulos publicados na revista mensal de mangás shōnen Bessatsu Shōnen Magazine da editora Kodansha de setembro de 2009 até abril de 2021, com os seus capítulos compilados em 34 volumes tankōbon.','https://img1.ak.crunchyroll.com/i/spire3/dac363972d628a7009e04fdeb9d7104a1641869274_full.jpg','1',5,'https://www.crunchyroll.com/pt-br/attack-on-titan',1)");
            migrationBuilder.Sql("INSERT INTO Animes(Nome,Descricao,ImagemUrl,IsAnimePreferido,Nota,SiteAssistirAnime,GeneroId)" +
                " VALUES('Tate No Yuusha','Iwatani Naofumi foi invocado em um mundo paralelo junto com três pessoas para serem os heróis desse mundo. Cada um deles respectivamente equipados com suas armas lendárias quando invocados, Naofumi recebe o Escudo Lendário como sua arma. Devido a sua falta de carisma e experiência, Naofumi é taxado como o mais fraco dos heróis, e acaba sendo traído, falsamente acusado e roubado no terceiro dia de aventura. Evitado por todos, do rei aos camponeses, a mente de Naofumi é preenchida por vingança e ódio. Assim, seu destino em um mundo paralelo começa...','https://animefire.net/img/animes/tate-no-yuusha-no-nariagari-large.webp?v=1',0,4,'https://www.crunchyroll.com/pt-br/the-rising-of-the-shield-hero',2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Animes");
        }
    }
}
