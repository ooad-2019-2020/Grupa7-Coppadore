using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Komentar
    {

        public int KomentarID { get; set; }
        [Display(Name ="Komentar")]
        public string komentarTekst { get; set; }
        [Display(Name ="Datum")]
        public DateTime datum { get; set; }

        public virtual ICollection<Film> Film { get; set; }
        public virtual ICollection<Korisnik> Korisnik { get; set; }

    }
}
