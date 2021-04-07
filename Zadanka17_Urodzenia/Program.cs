using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Zadanka17_Urodzenia
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"..\..\..\dane17.csv";
            var lines = File.ReadAllLines(filename);
            List<string> lista = new List<string>();
            foreach (var line in lines)
            {
                var value = line.Split(",");
                //dodanie do listy

                //wyświetlić w których latach ilość urodzeń była większa niż 11000 w grupie wiekowej 35 - 39                
                if (Int32.Parse(value[2]) > 11000 && value[1] == "35-39")
                {
                    Console.WriteLine($"{value[0]}, {value[1]}, {value[2]}");
                }


                //policzyć w ilu latach ilość urodzeń w grupie wiekowej poniżej 15 lat wyniosła więcej niż 25
                int suma = 0;
                if (Int32.Parse(value[3]) > 25 && value[1] == "Under 15")
                {
                    suma++;
                }
                Console.WriteLine(suma);
            }

        }
    }
}
