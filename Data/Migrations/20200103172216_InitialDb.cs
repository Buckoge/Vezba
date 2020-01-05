using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vezba.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artikli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true),
                    Cena = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikli", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Računi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPoručivanja = table.Column<DateTime>(nullable: false),
                    BrojRačuna = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Računi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoručeniArtikal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtikalId = table.Column<int>(nullable: true),
                    Količina = table.Column<int>(nullable: false),
                    Cena = table.Column<decimal>(nullable: false),
                    RačunId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoručeniArtikal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoručeniArtikal_Artikli_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PoručeniArtikal_Računi_RačunId",
                        column: x => x.RačunId,
                        principalTable: "Računi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoručeniArtikal_ArtikalId",
                table: "PoručeniArtikal",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_PoručeniArtikal_RačunId",
                table: "PoručeniArtikal",
                column: "RačunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoručeniArtikal");

            migrationBuilder.DropTable(
                name: "Artikli");

            migrationBuilder.DropTable(
                name: "Računi");
        }
    }
}
