using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Film
    {

        public int FilmID { get; set; }
        [Display(Name = "Naziv")]
        public string naziv { get; set; }
        [Display(Name = "Trajanje(min)")]
        public int trajanje { get; set; }
        [Display(Name = "Ocjena")]
        public double ocjena { get; set; }
        [Display(Name = "Godina filma")]
        public int godinaFilma { get; set; }
        [Display(Name = "Broj ocjena")]
        public int brojOcjena { get; set; }
        [Display(Name = "Opis filma")]
        public string opisFilma { get; set; }
        [Display(Name = "Režija")]
        public string reziser { get; set; }
        [Display(Name = "Cijena")]
        public double cijena { get; set; }
        public string poster { get; set; }
        public string link { get; set; }


    }
}
