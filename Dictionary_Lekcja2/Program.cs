using System;
using System.Collections.Generic;

namespace Dictionary_Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            //<nr rejestracyjny, samochod>
            Samochod s = new Samochod("Daewoo", "Matiz", 1999);

            Dictionary<string, Samochod> samochody = new Dictionary<string, Samochod>();
            samochody["LB125412"] = new Samochod("Ford", "Focus", 2005);
            samochody["LB254125"] = new Samochod("Volvo", "XC90", 2016);
            samochody["LB475125"] = s;
            samochody.Add("LB475123", new Samochod("Tesla", "S", 2020));

            Console.WriteLine(samochody["LB125412"].Wiek());
            Console.WriteLine();

            samochody.Remove("LB125412"); // usuwanie pary po nazwie klucza
            foreach (var item in samochody)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(samochody.ContainsKey("LB125412"));
            Console.WriteLine(samochody.ContainsKey("LB475123"));
        }
    }
}
