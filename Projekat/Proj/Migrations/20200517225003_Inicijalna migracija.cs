using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekat.Migrations
{
    public partial class Inicijalnamigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmZanr",
                columns: table => new
                {
                    FilmZanrID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmZanr", x => x.FilmZanrID);
                });

            migrationBuilder.CreateTable(
                name: "GlumacFilm",
                columns: table => new
                {
                    GlumacFilmID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlumacFilm", x => x.GlumacFilmID);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    KomentarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    komentarTekst = table.Column<string>(nullable: true),
                    datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.KomentarID);
                });

            migrationBuilder.CreateTable(
                name: "ListaPregledanih",
                columns: table => new
                {
                    ListaPregledanihID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPregledanih", x => x.ListaPregledanihID);
                });

            migrationBuilder.CreateTable(
                name: "ListaZelja",
                columns: table => new
                {
                    ListaZeljaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaZelja", x => x.ListaZeljaID);
                });

            migrationBuilder.CreateTable(
                name: "Zanr",
                columns: table => new
                {
                    ZanrID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmZanrID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanr", x => x.ZanrID);
                    table.ForeignKey(
                        name: "FK_Zanr_FilmZanr_FilmZanrID",
                        column: x => x.FilmZanrID,
                        principalTable: "FilmZanr",
                        principalColumn: "FilmZanrID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Glumac",
                columns: table => new
                {
                    GlumacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    GlumacFilmID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glumac", x => x.GlumacID);
                    table.ForeignKey(
                        name: "FK_Glumac_GlumacFilm_GlumacFilmID",
                        column: x => x.GlumacFilmID,
                        principalTable: "GlumacFilm",
                        principalColumn: "GlumacFilmID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(nullable: true),
                    trajanje = table.Column<int>(nullable: false),
                    ocjena = table.Column<double>(nullable: false),
                    godinaFilma = table.Column<int>(nullable: false),
                    brojOcjena = table.Column<int>(nullable: false),
                    opisFilma = table.Column<string>(nullable: true),
                    reziser = table.Column<string>(nullable: true),
                    cijena = table.Column<double>(nullable: false),
                    poster = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true),
                    FilmZanrID = table.Column<int>(nullable: true),
                    GlumacFilmID = table.Column<int>(nullable: true),
                    KomentarID = table.Column<int>(nullable: true),
                    ListaPregledanihID = table.Column<int>(nullable: true),
                    ListaZeljaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmID);
                    table.ForeignKey(
                        name: "FK_Film_FilmZanr_FilmZanrID",
                        column: x => x.FilmZanrID,
                        principalTable: "FilmZanr",
                        principalColumn: "FilmZanrID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Film_GlumacFilm_GlumacFilmID",
                        column: x => x.GlumacFilmID,
                        principalTable: "GlumacFilm",
                        principalColumn: "GlumacFilmID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Film_Komentar_KomentarID",
                        column: x => x.KomentarID,
                        principalTable: "Komentar",
                        principalColumn: "KomentarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Film_ListaPregledanih_ListaPregledanihID",
                        column: x => x.ListaPregledanihID,
                        principalTable: "ListaPregledanih",
                        principalColumn: "ListaPregledanihID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Film_ListaZelja_ListaZeljaID",
                        column: x => x.ListaZeljaID,
                        principalTable: "ListaZelja",
                        principalColumn: "ListaZeljaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    KomentarID = table.Column<int>(nullable: true),
                    ListaPregledanihID = table.Column<int>(nullable: true),
                    ListaZeljaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnik_Komentar_KomentarID",
                        column: x => x.KomentarID,
                        principalTable: "Komentar",
                        principalColumn: "KomentarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Korisnik_ListaPregledanih_ListaPregledanihID",
                        column: x => x.ListaPregledanihID,
                        principalTable: "ListaPregledanih",
                        principalColumn: "ListaPregledanihID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Korisnik_ListaZelja_ListaZeljaID",
                        column: x => x.ListaZeljaID,
                        principalTable: "ListaZelja",
                        principalColumn: "ListaZeljaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Placanje",
                columns: table => new
                {
                    PlacanjeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    brojkartice = table.Column<string>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placanje", x => x.PlacanjeID);
                    table.ForeignKey(
                        name: "FK_Placanje_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Film_FilmZanrID",
                table: "Film",
                column: "FilmZanrID");

            migrationBuilder.CreateIndex(
                name: "IX_Film_GlumacFilmID",
                table: "Film",
                column: "GlumacFilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Film_KomentarID",
                table: "Film",
                column: "KomentarID");

            migrationBuilder.CreateIndex(
                name: "IX_Film_ListaPregledanihID",
                table: "Film",
                column: "ListaPregledanihID");

            migrationBuilder.CreateIndex(
                name: "IX_Film_ListaZeljaID",
                table: "Film",
                column: "ListaZeljaID");

            migrationBuilder.CreateIndex(
                name: "IX_Glumac_GlumacFilmID",
                table: "Glumac",
                column: "GlumacFilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_KomentarID",
                table: "Korisnik",
                column: "KomentarID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_ListaPregledanihID",
                table: "Korisnik",
                column: "ListaPregledanihID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_ListaZeljaID",
                table: "Korisnik",
                column: "ListaZeljaID");

            migrationBuilder.CreateIndex(
                name: "IX_Placanje_KorisnikID",
                table: "Placanje",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Zanr_FilmZanrID",
                table: "Zanr",
                column: "FilmZanrID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Glumac");

            migrationBuilder.DropTable(
                name: "Placanje");

            migrationBuilder.DropTable(
                name: "Zanr");

            migrationBuilder.DropTable(
                name: "GlumacFilm");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "FilmZanr");

            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "ListaPregledanih");

            migrationBuilder.DropTable(
                name: "ListaZelja");
        }
    }
}
