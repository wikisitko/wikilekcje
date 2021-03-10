using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text.Json;

namespace DaneZNeta_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient(); 
            //pobieramy kod zrodlowy strony - tekst (czyli w tym przypadku json z danymi)
            string strona = client.DownloadString(@"https://www.cheapshark.com/api/1.0/deals?storeID=1&upperPrice=1000");

            //zamieniamy json zawarty w tekscie na jakies obiekty
            //Deserialize<Typ> Typ - musimy podac na jaki obiekt ma zamienic tego stringa
            List<Gra> gry = JsonSerializer.Deserialize<List<Gra>> (strona);

            //foreach (var item in gry)
            //{
            //    Console.WriteLine(item);
            //}

            //tworzymy liste slownikow
            List<Dictionary<string, object>> games = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(strona);
            double cenaZaAllGry = 0;
            foreach (var slownik in games)
            {
                /*foreach (var item in slownik)
                {
                    Console.WriteLine($"{item.Key} {item.Value}");
                }
                Console.WriteLine();*/
                Console.WriteLine(slownik["title"]);
                cenaZaAllGry += double.Parse(slownik["salePrice"].ToString(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine($"Cena all: {cenaZaAllGry}");
        }
    }
}
