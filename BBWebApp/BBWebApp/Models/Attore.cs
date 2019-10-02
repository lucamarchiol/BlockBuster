using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBWebApp.Models
{
    public class Attore
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        //public int annoNascita { get; set; }
        public string nazionalita { get; set; }
        public string urlFoto { get; set; }
    }
}
