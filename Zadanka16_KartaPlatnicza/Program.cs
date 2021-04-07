using System;
using System.Collections.Generic;
using System.IO;

namespace Zadanka16_KartaPlatnicza
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linie = File.ReadAllLines(@"..\..\..\dane.csv", System.Text.Encoding.UTF8);
            //Dane dane = new Dane();
            //for (int i = 1; i < linie.Length; i++)
            //{
            //    var wartosci = linie[i].Split(",");
            //    InfoWydatki info = new InfoWydatki(wartosci[0], int.Parse(wartosci[1]),
            //        double.Parse(wartosci[2], CultureInfo.InvariantCulture),
            //        double.Parse(wartosci[3], CultureInfo.InvariantCulture),
            //        double.Parse(wartosci[4], CultureInfo.InvariantCulture));
            //    dane.DodajInfo(info);
            //}

            //dane.Pokaz();


            //@"..\..\..\dane.csv"

            Transakcja t = new Transakcja(@"..\..\..\dane.csv");
            Console.WriteLine(t.AlkoSuma());
            Console.WriteLine();
            t.Filtruj("Liquor").ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine(t.MaxTransakcja());
        }
    }
}
