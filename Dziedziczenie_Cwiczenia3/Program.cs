using System;
using System.Collections.Generic;

namespace Dziedziczenie_Cwiczenia3
{
    class Program
    {
        static void Main(string[] args)
        {
            //[x] kompozycja - gdy obiekt jednej klasy posiada w sobie obiekt innej klasy. Grupa posiada jednego wychowawce
            //[x] agregacja - gdy obiekt jednej klasy posiada wiele obiektow innej klasy. Grupa moze miec wielu uczniow
            //[x] dziedziczenie

            Nauczyciel n = new Nauczyciel("Jan", "Kowalski", "01/05/1968", "682541234785", Plec.Mezczyzna, "fizyka", "01/09/2015");
            Console.WriteLine(n);

            Uczen u = new Uczen("Ola", "Nowak", "18/04/2000", "002541234781", Plec.Kobieta, 5, "bardzo dobre");
            Console.WriteLine(u);

            Uczen u2 = new Uczen("Ada", "Piekarz", "17/12/1999", "992541234781", Plec.Kobieta, 4, "dobre");
            Console.WriteLine(u2);

            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(n);
            osoby.Add(u);
            osoby.Add(u2);

            Console.WriteLine();
            foreach (var os in osoby)
            {
                Console.WriteLine(os);
                Console.WriteLine($"Skladka: {os.ObliczUbezpieczenie()}zł"); //tutaj zadziala polimorfizm
                Console.WriteLine();
            }

            int licznik = 0;
            foreach (var os in osoby)
            {
                if(os.Plec == Plec.Kobieta)
                {
                    licznik++;
                }
            }

            Console.WriteLine($"Ile kobiet: {licznik}");

            Grupa g = new Grupa(n, "IIID");
            g.DodajUcznia(u);
            g.DodajUcznia(u2);

            Console.WriteLine();
            Console.WriteLine(g);

            Console.WriteLine($"Srednia ocen: {g.SredniaOcen()}");
            Console.WriteLine($"Kobiety: {g.IleOsob(Plec.Kobieta)}");
            Console.WriteLine($"Mezczyzni: {g.IleOsob(Plec.Mezczyzna)}");

            Console.ReadLine();
        }
    }
}
