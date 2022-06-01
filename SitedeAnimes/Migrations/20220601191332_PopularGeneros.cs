using Microsoft.EntityFrameworkCore.Migrations;

namespace SitedeAnimes.Migrations
{
    public partial class PopularGeneros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Generos(Nome)" +
                " VALUES('Aventura')");
            migrationBuilder.Sql("INSERT INTO Generos(Nome)" +
                " VALUES('Ação')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Generos");
        }
    }
}
