using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class GlumacFilm
    {
        public int GlumacFilmID { get; set; }
        public virtual ICollection<Film> Film { get; set; }
        public virtual ICollection<Glumac> Glumac { get; set; }

    }
}
