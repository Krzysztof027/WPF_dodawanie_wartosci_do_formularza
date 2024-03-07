using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Notatka
    {
        public string Tytul { get; set; }

        public string Tresc { get; set; }

        public static int Licznik { get; set; } = 0;

        public Notatka(string tytul, string tresc)
        {
            Tytul = tytul;
            Tresc = tresc;
            Licznik = Licznik + 1; /* Licznik++ */
        }
    }
}
