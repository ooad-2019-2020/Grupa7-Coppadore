using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Placanje
    {

        public int PlacanjeID{ get; set; }
        public DateTime Datum { get; set; }
        [Display (Name = "Broj računa")]
        public string brojkartice { get; set; }

    }
}
