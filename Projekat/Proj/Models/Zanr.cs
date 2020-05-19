using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Zanr
    {
        public int ZanrID { get; set; }
        [Display(Name = "Žanr")]
        string naziv { get; set; }
    }
}
