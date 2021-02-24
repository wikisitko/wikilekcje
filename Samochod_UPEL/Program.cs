using System;

namespace Samochod_UPEL
{
    class Program
    {
        static void Main(string[] args)
        {
            WlascicielK w = new WlascicielK("Jan", "Kowalski", "123456789", true);
            Console.WriteLine(w);

            SamochodK s = new SamochodK(w, Marka.Mercedes);
            Console.WriteLine(s);

            PostojK p = new PostojK(s, "10/02/2020 10:16");
            Console.WriteLine(p);
            Console.WriteLine($"Zakoncz postoj: {p.Zakoncz(p)}");
            Console.WriteLine(p);

            Console.WriteLine(p.ObliczOplate() + "ZŁ"); //to trochę nie działa jak dni są różne...

        }
    }
}
