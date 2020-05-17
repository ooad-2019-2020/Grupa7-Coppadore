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
        
        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Placanje>().ToTable("Placanje");
        }
    }
}