using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekat.Models;

namespace AspNetCoreMVC.Models
{
    public class OOADContext : DbContext
    {
        public OOADContext(DbContextOptions<OOADContext> options) : base(options)
        {
        }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Placanje> Placanje{ get; set; }
        
        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Placanje>().ToTable("Placanje");
        }
    }
}