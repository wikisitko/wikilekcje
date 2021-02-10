using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializacjaLekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Ada", "Kowalska", "125481254", 50);
            o.Oceny.Add(new Ocena(5, "PRM"));
            o.Oceny.Add(new Ocena(4.5, "PROE"));
            o.Oceny.Add(new Ocena(3.5, "AiSD"));
            Console.WriteLine(o);


            o.ZapisXML("zapis.xml");
            o.ZapisBin("zapis.bin");
            o.ZapisJSON("zapis.json");

            //XML -> HTML
            //JSON
            //binarny

            Osoba x = Osoba.WczytajXML("zapis.xml");
            Console.WriteLine(x);

            Osoba os = Osoba.WczytajBin("zapis.bin");
            Console.WriteLine(os);

            Console.ReadLine();
        }
    }
}
