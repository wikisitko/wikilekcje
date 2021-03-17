using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Zadanka14_KursZlota
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ////string adres = @"http://api.nbp.pl/api/cenyzlota/last/30/?format=json";

            ////List<KursZlota> kursy = JsonSerializer.Deserialize<List<KursZlota>>(adres);
            //Kursy k1 = new Kursy(@"http://api.nbp.pl/api/cenyzlota/last/30/?format=json");

            //Console.WriteLine(k1);

            Kursy k = new Kursy("http://api.nbp.pl/api/cenyzlota/last/10/?format=json");
            Console.WriteLine(k);
            k.SortujCena(); //posortuje kursy po cenie
            Console.WriteLine(k);
            k.SortujData(); //posortuje kursy po dacie
            Console.WriteLine(k);
            var x = k.Szukaj(new DateTime(2021, 3, 10));
            Console.WriteLine(x); //wyświetli kurs za dzień 10.03.2021 lub null
            var lista = k.TanszeNiz(210); //zwraca listę kursów tanszych niz 220zł
            lista.Pokaz(); //wyświetla zawartość listy (metoda rozszerzająca)
            Console.WriteLine();
            var lista2 = k.TanszeNiz(null); //zwraca listę wszystkich kursów
            lista2.Pokaz();
        }
    }
}
