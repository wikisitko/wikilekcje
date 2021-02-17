using System;

namespace Plyta_Glowna
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram r1 = new Ram("Kingstone", 8);
            Ram r2 = new Ram("HyperX", 8);
            Ram r3 = new Ram("Samsung", 2);

            PlytaGlowna plyta = new PlytaGlowna("Gigabyte", 16);
            Console.WriteLine(plyta);

            plyta.Dodaj(r1);
            Console.WriteLine(plyta);

            plyta.Dodaj(r2);
            Console.WriteLine(plyta);

            plyta.Dodaj(r3);
            Console.WriteLine(plyta);

            //plyta.ZapisXML("plyta.xml");
            //PlytaGlowna x = PlytaGlowna.OdczytXML("plyta.xml");

            //Console.WriteLine(x);
        }
    }
}
