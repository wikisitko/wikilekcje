using System;
using System.Collections.Generic;

namespace InterfejsySystemowe_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Samochod> samochody = new List<Samochod>()
            {
                new Samochod("Tesla", "Focus", 2001),
                new Samochod("Ford", "Focus", 2005),
                new Samochod("Volvo", "XC90", 2016),
                new Samochod("Tesla", "S", 2020),
                new Samochod("Daewoo", "Matiz", 1999),
            };
            samochody.Sort(); //uzywa domyslnego compareTo z klasy samochod

            foreach (var item in samochody)
            {
                Console.WriteLine(item);
            }

            if(samochody[0].CompareTo(samochody[1]) == 0)
            {
                Console.WriteLine("Sa sobie rowne!");
            }

            Console.WriteLine();
            samochody.Sort(new SamochodWiekComparer());
            foreach (var item in samochody)
            {
                Console.WriteLine(item);
            }
        }
    }
}
