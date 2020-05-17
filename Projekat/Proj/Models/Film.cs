using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Film
    {

        public int FilmID { get; set; }
        public string naziv { get; set; }
        public int trajanje { get; set; }
        public double ocjena { get; set; }
        public int godinaFilma { get; set; }
        public int brojOcjena { get; set; }
        public string opisFilma { get; set; }
        public string reziser { get; set; }
        public double cijena { get; set; }
        public string poster { get; set; }
        public string link { get; set; }


    }
}
