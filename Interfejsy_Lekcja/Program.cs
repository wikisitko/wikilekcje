using System;
using System.Collections.Generic;

namespace Interfejsy_Lekcja
{
    class Program
    {
        static void ZapiszAll(List<IZapis> elementy)
        {
            for(int i = 0; i < elementy.Count; i++)
            {
                elementy[i].ZapiszCSV($"{i}.xml");
            }
        }
        static void Main(string[] args)
        {
            //interfejs - to taka klasa abstarkcyjna ktora posiada jedynie metody publiczne abstrakcyjne
            Console.WriteLine("Hello World!");

            Punkt p = new Punkt(5, 9);
            Console.WriteLine(p);
            Console.WriteLine(p.OdlegloscOdSrodka());
            p.ZapiszCSV("p.csv");
            p.ZapiszXML("p.xml");

            //nie mozna zrobic obiektu z interfejsu (tak sam jest z klasa abstrakcyjna)
            //ale mozna zrobic zmienna ktora wskazuje na jakis obiekt

            IZapis z = new Punkt(1, 1);
            z.ZapiszCSV("p2.csv"); //za pomoca zmiennej typu danego interfejsu mozemy sie odnosic do metod obiektu ktore ten interfejs "zna"
            z.ZapiszXML("p2.xml");


            //kolejna klasa:
            Hero h = new Hero("ImprezowaLama");
            h.Walcz();
            Console.WriteLine(h);
            h.ZapiszCSV("h.csv");
            h.ZapiszXML("h.xml");

            //jak to bedzie z interfejsem
            z = h;
            z.ZapiszCSV("h2.csv");
            z.ZapiszXML("h2.xml");

            //stworzylem liste obiektow ale jedyne co o nich tutaj wiemy to to ze maja metody ZapiszXml i ZapiszCSV
            List<IZapis> doZapisu = new List<IZapis>();
            doZapisu.Add(new Hero("Player"));
            doZapisu.Add(new Hero("Player2"));
            doZapisu.Add(new Hero("Player3"));
            doZapisu.Add(new Punkt(8, 8));

            ZapiszAll(doZapisu);
        }
    }
}
