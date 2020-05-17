using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class FilmZanr
    {
        public int FilmZanrID {get;set;}
        public virtual ICollection<Film> Film { get; set; }
        public virtual ICollection<Zanr> Zanr { get; set; }

    }
}
