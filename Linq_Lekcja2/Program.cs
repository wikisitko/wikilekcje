using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] imiona = new string[] { "Adam", "Ada", "Ola", "Kinga", "Tomasz", "Janusz", "Patrycja", "Zenon" };
            string[] nazwiska = new string[] { "Kowalski", "Nowak", "Piekarski" };
            string[] miasta = new string[] { "Warszawa", "Lublin", "Chelm", "Krakow", "Wroclaw", "Gdansk", "Radom" };

            List<Osoba> osoby = new List<Osoba>();
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                string imie = imiona[rand.Next(imiona.Length)];
                string nazwisko = nazwiska[rand.Next(nazwiska.Length)];
                DateTime data = new DateTime(rand.Next(1980, 2015), rand.Next(1, 13), rand.Next(1, 29));
                string miasto = miasta[rand.Next(miasta.Length)];
                osoby.Add(new Osoba(imie, nazwisko, data, miasto));
            }

            osoby.ForEach(o => Console.WriteLine(o));
            Console.WriteLine();
            osoby.FindAll(o => o.RokUrodzenia.Year > 2000).ForEach(o => Console.WriteLine(o));

            Console.WriteLine();
            osoby.FindAll(o => o.Miasto == "Lublin" || o.Miasto == "Krakow").ForEach(o => Console.WriteLine(o));

            int ileJanuszy = osoby.Count(o => o.Imie == "Janusz");
            Console.WriteLine(ileJanuszy);

            Console.WriteLine(osoby.Any(o => o.RokUrodzenia.Year < 1990));

            //List<string> im = new List<string>();
            //foreach (var item in osoby)
            //{
            //    im.Add(item.Imie);
            //}
            //im.ForEach(x => Console.WriteLine(x));

            List<string> im = osoby.Select(x => x.Imie).ToList(); //zamienia liste obiektow klasy Osoba na liste imion typu string
            im.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //List<int> lata = osoby.FindAll(x => x.RokUrodzenia.Year < 2000).Select(x => x.RokUrodzenia.Year).ToList();
            List<int> lata = osoby.Select(x => x.RokUrodzenia.Year).Where(x => x < 2000).ToList();
            lata.ForEach(x => Console.WriteLine(x));

            List<int> liczby = new List<int>() { 5, 9, 8, 10, 4, 7, 8, 10, 5, 6, 9, 100 };
            List<double> wynik = liczby.Select(x => Math.Sqrt(x)).ToList();

            wynik.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            List<DaneOsobowe> dane = osoby.Select(x => new DaneOsobowe(DateTime.Now.Year - x.RokUrodzenia.Year, x.Miasto)).ToList();
            dane.ForEach(x => Console.WriteLine(x));

            var slownik = osoby.GroupBy(x => x.Miasto);
            foreach (var item in slownik)
            {
                Console.WriteLine(item.Key);
                foreach (var os in item)
                {
                    Console.WriteLine("   " + os);
                }
            }

            Console.WriteLine();
            List<int> numerki = Enumerable.Range(0, 20).ToList();
            List<int> losowe = Enumerable.Range(0, 5).Select(x => rand.Next(5, 50)).ToList();
        }
    }
}
