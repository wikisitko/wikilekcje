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
            a.ZamowKawe("duza");
            a.ZamowKawe("mala");
            a.Wrzuc(new Moneta());
            a.Wrzuc(new Moneta());
            a.Wrzuc(new Moneta());
            a.ZamowKawe("duza");
            Console.WriteLine(a);
        }
    }
}
