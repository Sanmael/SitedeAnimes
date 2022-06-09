using Microsoft.EntityFrameworkCore.Migrations;

namespace SitedeAnimes.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnoDeLancamento",
                table: "Animes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NomeDoDiretor",
                table: "Animes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "NumeroDeEpisodios",
                table: "Animes",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "NumeroDeTemporadas",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoDeLancamento",
                table: "Animes");

            migrationBuilder.DropColumn(
                name: "NomeDoDiretor",
                table: "Animes");

            migrationBuilder.DropColumn(
                name: "NumeroDeEpisodios",
                table: "Animes");

            migrationBuilder.DropColumn(
                name: "NumeroDeTemporadas",
                table: "Animes");
        }
    }
}
