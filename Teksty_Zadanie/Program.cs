using System;
using System.Collections.Generic;

namespace Teksty_Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Ksiazka k1 = new Ksiazka("Teresa Li", "Mlodosc", "Ala ma kota");
            Ksiazka k2 = new Ksiazka("Adam Bo", "Starosc", "kot ma Ale");
            //Ksiazka k3 = new Ksiazka("Adam Bo", "Mein Kampf", "kot ma Ale");

            Artykul a1 = new Artykul("10/01/1997", "Kaktus", "Rosliny sa zielone");
            Artykul a2 = new Artykul("04/06/2001", "Niebo", "Niebo jest niebieskie");

            Wiersz w1 = new Wiersz("Nie umiem rymowac", Rodzaj.Sylabiczny);
            Wiersz w2 = new Wiersz("La La La La La", Rodzaj.Stroficzny);

            List<Tekst> teksty = new List<Tekst>();
            teksty.Add(k1);
            teksty.Add(k2);
            teksty.Add(a1);
            teksty.Add(a2);
            teksty.Add(w1);
            teksty.Add(w2);

            foreach (var tekst in teksty)
            {
                tekst.ObliczWartosc();
                Console.WriteLine(tekst.ObliczWartosc());
            }

          


        }
    }
}
