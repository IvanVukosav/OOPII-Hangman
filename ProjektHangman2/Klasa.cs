using ProjektHangman2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektHangman2
{

    public class Klasa
    {
        public static Form1 form;
        private int resetiraj = 0;
        public void funkcija()
        {
            Klasa.form.UcitajRijeci();
            Klasa.form.Prikaz();
        }
           public int reset 
            {
                get { return resetiraj; } 
                set { resetiraj = value; } 
            } 
    }
}
