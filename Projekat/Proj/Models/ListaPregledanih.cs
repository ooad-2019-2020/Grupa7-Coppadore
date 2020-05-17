using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class ListaPregledanih
    {
        public int ListaPregledanihID { get; set; }
        public virtual ICollection<Film> Film { get; set; }
        public virtual ICollection<Korisnik> Korisnik { get; set; }

    }
}
