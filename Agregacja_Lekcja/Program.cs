using System;

namespace Agregacja_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bankomat b = new Bankomat("Warszawa Wolumen");
            //b.Wplac(new Wplata(0, 650));
            //b.Wplac(new Wplata(1, 50));
            //b.Wplac(new Wplata(2, 33));

            //Console.WriteLine(b.AllGrosze());

            //b.ZapisXML("Bankomat.xml");

            Bankomat b2 = Bankomat.WczytajXML("Bankomat.xml");

            Console.WriteLine(b2);
            Console.WriteLine($"Max wplata: {b2.MaxWplata()}");
        }
    }
}
