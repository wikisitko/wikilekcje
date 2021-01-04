using System;
using System.IO;

namespace programLekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            Lekcja[] lekcje = ZaladujLekcje(@"C:\Users\Wiktoria Sitko\Documents\GitHub\wikilekcje\programLekcje\lekcje.csv");
            WyswietlLekcje(lekcje);

                       
        }

        static Lekcja[] ZaladujLekcje(string nazwaPliku)
        {
            var linie = File.ReadAllLines(nazwaPliku);
            Lekcja[] lekcje = new Lekcja[linie.Length];

            for(int i = 0; i < lekcje.Length; i++)
            {
                var linia = linie[i].Split(",");
                Lekcja l1 = new Lekcja(linia[0], linia[1], linia[2], Int32.Parse(linia[3]));
                lekcje[i] = l1;
            }
            return lekcje;
        }

        static void WyswietlLekcje(Lekcja[] lekcje)
        {
            for (int i = 0; i < lekcje.Length; i++)
            {
                Console.WriteLine(lekcje[i]);
            }
        }

        static void KtoPing(Lekcja[] lekcje)
        {
            for (int i = 0; i < lekcje.Length; i++)
            {
                if (/*jak się dostać do "payment"?*/ == "ping")
                {

                }
            }

            
        }
    }
}
