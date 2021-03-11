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
            Console.WriteLine("Hello World!");
            
            //string adres = @"http://api.nbp.pl/api/cenyzlota/last/30/?format=json";

            //List<KursZlota> kursy = JsonSerializer.Deserialize<List<KursZlota>>(adres);
            Kursy k1 = new Kursy(@"http://api.nbp.pl/api/cenyzlota/last/30/?format=json");

            Console.WriteLine(k1);
        }
    }
}
