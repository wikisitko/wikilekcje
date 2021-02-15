using System;

namespace Dziedziczenie_Cwiczenia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Paczka p = new Paczka(5, "Jan Kowalski");
            Paczka p2 = new PaczkaEkspresowa(6, "Ada Piekarz", "16/02/2021");
            Paczka p3 = new PaczkaEkspresowa(4.5, "Ola Nowak");

            Klient k = new Klient("Janusz");
            k.DodajPaczke(p);
            k.DodajPaczke(p2);
            k.DodajPaczke(p3);

            Console.WriteLine(k);
            Console.WriteLine(k.Zaplata());

            k.ZapisXML("klient.xml");
            Klient k2 = Klient.WczytajXML("klient.xml");
            Console.WriteLine(k2);

            Console.ReadLine();
        }
    }
}
