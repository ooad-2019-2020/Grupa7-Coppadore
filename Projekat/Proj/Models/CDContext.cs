using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekat.Models;

namespace Projekat.Models
{
    public class CDContext : DbContext
    {
        public CDContext(DbContextOptions<CDContext> options) : base(options)
        {
        }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Placanje> Placanje{ get; set; }
        public DbSet<Komentar> Komentar { get; set; }
        public DbSet<ListaZelja> ListaZelja { get; set; }
        public DbSet<ListaPregledanih> ListaPregledanih { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Zanr> Zanr { get; set; }
        public DbSet<FilmZanr> FilmZanr { get; set; }
        public DbSet<Glumac> Glumac { get; set; }
        public DbSet<GlumacFilm> GlumacFilm { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Placanje>().ToTable("Placanje");
            modelBuilder.Entity<Komentar>().ToTable("Komentar");
            modelBuilder.Entity<ListaZelja>().ToTable("ListaZelja");
            modelBuilder.Entity<ListaPregledanih>().ToTable("ListaPregledanih");
            modelBuilder.Entity<Film>().ToTable("Film");
            modelBuilder.Entity<Zanr>().ToTable("Zanr");
            modelBuilder.Entity<FilmZanr>().ToTable("FilmZanr");
            modelBuilder.Entity<Glumac>().ToTable("Glumac");
            modelBuilder.Entity<GlumacFilm>().ToTable("GlumacFilm");
        }
    }
}