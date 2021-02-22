using System;

namespace Samochod_UPEL
{
    class Program
    {
        static void Main(string[] args)
        {
            WlascicielK w = new WlascicielK("Jan", "Kowalski", "123456789", true);
            Console.WriteLine(w);

            SamochodK s = new SamochodK();
            //Console.WriteLine(s);

            PostojK p = new PostojK("10/02/2020 10:16");
            Console.WriteLine(p);
            p.Zakoncz(p);
            Console.WriteLine(p);

            Console.WriteLine(p.ObliczOplate() + "ZŁ"); //to trochę nie działa jak dni są różne...
        }
    }
}
