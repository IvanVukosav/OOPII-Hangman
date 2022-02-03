using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace ProjektHangman2
{
   public class Spremanje
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public int Pogresni{ get; set; }
        public override string ToString()
        {
            return "Ime: " + ime +
                " Prezime: " + prezime +
                " Broj pogresnih: " + Pogresni;
        }
    }
   

}

