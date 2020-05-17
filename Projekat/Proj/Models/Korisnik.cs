using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Korisnik
    {
        // dio klase u kojem definišemo atribute
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        //dio u kojem se definišu veze sa ostalim klasama
        public virtual ICollection<Placanje> Placanje { get; set; }
    }





}
