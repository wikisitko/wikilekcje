using System;
using System.Collections.Generic;

namespace Teksty_Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tekst t = new Tekst("Ada ma kota"); - juz nie dziala
            Tekst x = new Ksiazka("Teresa Li", "Mlodosc", "Ala ma kota"); //ten dziala, mozna tak zapisac bo ksiazka dziedziczy po klasie Tekst
            
            Ksiazka k1 = new Ksiazka("Teresa Li", "Mlodosc", "Ala ma kota");
            Ksiazka k2 = new Ksiazka("Adam Bo", "Starosc", "kot ma Ale");
            
            try
            {
                Ksiazka k3 = new Ksiazka("Adam Bo", "Mein Kampf", "kot ma Ale");
            }
            catch(ZakazaneException z)
            {
                Console.WriteLine("Nie mozna stworzyc takiej ksiazki!");
            }
            


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
