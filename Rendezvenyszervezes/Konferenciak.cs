using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendezvenyszervezes
{
    internal class Konferenciak : Rendezvenyek
    {
        public string[] EloadokNeve { get; set; }
        public bool Mosdoszunet { get; set; }
        public string Tema { get; set; }
        public const int MOSDOSZUNETHOSSZ = 10;

        public Konferenciak() : base()
        {
            EloadokNeve = new string[0];
            Mosdoszunet = false;
            Tema = "";
        }

        public Konferenciak(DateTime datum, string helyszinCime, int hossz, int maxLetszam, string nev, int resztvevokSzama, string[] eloadokNeve, bool mosdoszunet, string tema)
            : base(datum, helyszinCime, hossz, maxLetszam, nev, resztvevokSzama)
        {
            EloadokNeve = eloadokNeve;
            Mosdoszunet = mosdoszunet;
            Tema = tema;
        }

        public void eloadasokHossza()
        { foreach (string eloado in EloadokNeve)
            if (Mosdoszunet)
                { Console.WriteLine($"{eloado} előadásának hossza: {Hossz / EloadokNeve.Length - MOSDOSZUNETHOSSZ} perc"); }
            else 
                { Console.WriteLine($"{eloado} előadásának hossza: {Hossz / EloadokNeve.Length} perc"); }

        }



    }
}
