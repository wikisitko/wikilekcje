using System;
using System.Collections.Generic;

namespace Waluty_Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            PLN p = new PLN(15);
            EUR e = new EUR(10);
            USD d = new USD(5);

            Console.WriteLine(p);
            Console.WriteLine(e);
            Console.WriteLine(d);

            List<Waluta> waluty = new List<Waluta>() { p, e, d }; //p, e i d beda wlozone do listy w momencie tworzenia listy
            Console.WriteLine(Waluta.Suma(waluty));
        }
    }
}
