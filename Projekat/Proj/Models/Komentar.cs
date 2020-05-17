using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Komentar
    {

        public int KomentarID { get; set; }
        public string komentar { get; set; }
        public DateTime datum { get; set; }

        public virtual ICollection<Film> Film { get; set; }
        public virtual ICollection<Korisnik> Korisnik { get; set; }

    }
}
