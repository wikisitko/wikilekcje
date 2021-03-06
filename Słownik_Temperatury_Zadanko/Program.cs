using System;
using System.Collections.Generic;
using System.Text;

namespace Słownik_Temperatury_Zadanko
{
    class Program
    {
        //double Powyzej(????)
        //{
        //    foreach (var item in ????)
        //    {
        //        if (item.Value > 20)
        //        {
        //            return item.Key;
        //        }                
        //    }
        //    return 0;
        //}
        static void Main(string[] args)
        {
            Dictionary<string, double> data = new Dictionary<string, double>()
            {
                {"Warszawa", 17.67 },
                {"Kraków", 19.32 },
                {"Wrocław", 22.31 },
                {"Katowice", 17.77 },
                {"Rzeszów", 24.16 },
                {"Poznań", 19.86 }

            };

            //Temp wyższa niż 20 stopni:
            Console.WriteLine("Temperatura wyższa niż 20 stopni: ");
            foreach (var item in data)
            {
                if (item.Value > 20)
                {
                    Console.WriteLine($" {item.Key}");
                }
            }

            //Średnia temp
            Console.WriteLine("Średnia temperatura: ");
            double srednia = 0;
            foreach (var item in data)
            {
                srednia += item.Value;
            }
            Console.WriteLine(srednia/data.Count);

            //mniejsza temp niz Poznan
            Console.WriteLine("Temperatura niższa niż Poznań: ");
            foreach (var item in data)
            {
                if (item.Value < data["Poznań"])
                {
                    Console.WriteLine($" {item.Key}");
                }
            }

            //temp max
            Console.WriteLine("Najwyższa temperatura: ");
            double max = 0;
            foreach (var item in data)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                }
            }
            Console.WriteLine(max);

            //min
            Console.WriteLine("Najniższa temperatura: ");
            double min = max;
            foreach (var item in data)
            {
                if (item.Value < min)
                {
                    min = item.Value;
                }
            }
            Console.WriteLine(min);

            //sortowanie
            

        }
    }
}
