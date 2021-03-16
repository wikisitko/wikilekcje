using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;

namespace Linq_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imiona = new List<string>() { "Ada", "Ola", "Iga", "Monika", "Zofia", "Ala" };
            List<int> liczby = new List<int> { 5, 6, 9, 8, 1, 0, 1, 10, 1, 5, 4, -1, 5};
            //List<int> parzyste = new List<int>();
            //foreach (var item in liczby)
            //{
            //    if(item % 2 == 0)
            //    {
            //        parzyste.Add(item);
            //    }
            //}
            List<int> parzyste = liczby.FindAll(item => item % 2 == 0); //wez kazdy element z listy liczby ktory spelnia zalozenie podzielnosci przez 2
            List<string> imiona3 = imiona.FindAll(item => item.Length == 3);
            //foreach (var item in imiona3)
            //{
            //    Console.WriteLine(item);
            //}
            imiona3.ForEach(item => Console.WriteLine(item)); //na kazdym elementcie z listy wykonaj jakas operacje

            Console.WriteLine();
            List<string> imionaDuze = imiona.FindAll(item => item[0] == 'A' && item.EndsWith('a'));
            imionaDuze.ForEach(item => Console.WriteLine(item));

            liczby.FindAll(x => x % 5 == 0).ForEach(x => Console.WriteLine(x));

            //zliczanie elementow pod jakims warunkiem
            int ile = imiona.Count(x => x.Length > 3);
            Console.WriteLine($"Imiona dluzsze niz 3 litery ilosc: {ile}");

            //All() - zwraca (bool) true jesli wszystkie elementy spelniaja jakis warunek
            if(liczby.All(x => x > 0))
            {
                Console.WriteLine("Wszystkie sa dodatnie");
            }
            else
            {
                Console.WriteLine("Niewszystkie sa dodatnie");
            }

            //Any() zwraca true jesli przynajmniej jeden element spelnia podany warunek
            Console.WriteLine($"Czy jest jakakolwiek liczba mniejsza od 0? {liczby.Any(x => x < 0)}");

            //znajdz pierwszej wystapienie imiena na literke A
            string wynik = imiona.Find(x => x[0] == 'A');
            Console.WriteLine(wynik);

            imiona.Sort();
            List<string> pierwsze3 = imiona.Take(3).ToList(); //pobierz pierwsze 3 elementy z listy i zwroc nowa liste
            List<string> imionaBez2Pierwszych = imiona.Skip(2).ToList(); //zwraca liste elementow ale bez 2 pierwszych

            List<int> liczbyFajne = liczby.Skip(3).Take(5).ToList();

            //string sciezka = @"C:\users\wiki\desktop"; //@ - jesli w stringu jest / to nie jest znakiem specjalnym
            //WebClient client = new WebClient();
            //string strona = client.DownloadString(@"https://api.covid19api.com/summary");
            //var lista = JsonSerializer.Deserialize<List<KursZlota>>(strona);
        }
    }
}
