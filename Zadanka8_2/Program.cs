using System;

namespace Zadanka8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Automat a = new Automat();
            a.Wrzuc(new Moneta());
            a.Wrzuc(new Moneta());
            a.ZamowKawe(KawaWielkosc.Duza);
            a.ZamowKawe(KawaWielkosc.Mala);
            a.Wrzuc(new Moneta());
            a.Wrzuc(new Moneta());
            a.Wrzuc(new Moneta());
            a.ZamowKawe(KawaWielkosc.Duza);
            Console.WriteLine(a);
        }
    }
}
