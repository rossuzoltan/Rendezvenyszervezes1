using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendezvenyszervezes
{
    internal class Rendezvenyek
    {
        public DateTime Datum { get; set; }
        public string HelyszinCime { get; set; }
        protected int Hossz { get; set; } 
        public int MaxLetszam { get; set; }
        public string Nev { get; set; }
        public int ResztvevokSzama { get; set; }

        public Rendezvenyek() {
            Datum = DateTime.Now;
            HelyszinCime = "";
            Hossz = 0;
            MaxLetszam = 0;
            Nev = "";
            ResztvevokSzama = 0;

        }

        public Rendezvenyek(DateTime datum, string helyszinCime, int hossz, int maxLetszam, string nev, int resztvevokSzama)
        {
            Datum = datum;
            HelyszinCime = helyszinCime;
            Hossz = hossz;
            MaxLetszam = maxLetszam;
            Nev = nev;
            ResztvevokSzama = resztvevokSzama;
        }

        public void RendezvenyInfo(string VasarloNev)
        {
            int NapokSzama = (Datum - DateTime.Now).Days;


            if (MaxLetszam <= ResztvevokSzama)
            {
                Console.WriteLine($"Kedves {VasarloNev}, a {Nev} rendezveny {NapokSzama} nap mulva lesz, már teltház van.");
                return;
            }
            if (MaxLetszam > ResztvevokSzama)
            {
                Console.WriteLine($"Kedves {VasarloNev}, a {Nev} rendezveny {NapokSzama} nap mulva lesz, még van hely!");
                    return;
            }

        }

        public void ResztvevoHozzaad(int PlusszFo) 
        { 
            int Kulonbseg = MaxLetszam - ResztvevokSzama;
            int Nemferbe = PlusszFo - Kulonbseg;
            if (PlusszFo <= Kulonbseg)
            {
                ResztvevokSzama += PlusszFo;
                Console.WriteLine($"Sikeresen felvettük a {PlusszFo} főt, jelenleg {ResztvevokSzama} fő van a rendezvényen.");
                return;
            }

            if (PlusszFo > Kulonbseg)
            {
                Console.WriteLine($"Még {Kulonbseg} befért, de teltház miatt további {Nemferbe} nem fér be a {Nev} esemnyre! ");
                return;
            }
        }




    }
}
