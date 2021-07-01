using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;

namespace serializacjaJSONzadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = @"C:\Users\Wiktoria Sitko\Documents\GitHub\wikilekcje\serializacjaJSONzadanie\160221.json";
            //string sciezka = "160221.json";

            var text = File.ReadAllText(sciezka);
            List<Przypadek> listaPrzypadkow = System.Text.Json.JsonSerializer.Deserialize<List<Przypadek>>(text);

            foreach (var item in listaPrzypadkow)
            {
                Console.WriteLine(item);
            }
        }
    }
}
