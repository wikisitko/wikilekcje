using System;

namespace Zadanka8
{
    class Program
    {
        static void Main(string[] args)
        {
            Gracz g = new Gracz("Ada", "Kowalska", 845);
            Gracz g2 = new Gracz("Ola", "Nowak", 900);
            Gracz g3 = new Gracz("Ala", "Piekarz", 154);

            Turniej t = new Turniej("Zawody 2k21");
            t.Dodaj(g);
            t.Dodaj(g2);
            t.Dodaj(g3);
            Console.WriteLine(t);
            Console.WriteLine(t.MaxPunkty());
            t.ZapiszXML("zawody.xml");
            Turniej t2 = Turniej.WczytajXML("zawody.xml");
            Console.WriteLine(t2);
            Console.ReadLine();
        }
    }
}
