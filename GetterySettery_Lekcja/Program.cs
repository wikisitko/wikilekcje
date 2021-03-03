using System;

namespace GetterySettery_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba();
            o.Imie = "Jan";
            o.Nazwisko = "Kowalski";
            Console.WriteLine(o.Nazwa);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(o.Losowa);
            }
        }
    }
}
