using System;
using System.Collections.Generic;
using System.Text;

namespace Słownik_Temperatury_Zadanko
{
    class Program
    {
        /*static double Powyzej(Dictionary<string, double> data)
        {
            foreach (var item in data)
            {
                if (item.Value > 20)
                {
                    return item.Key;
                }
            }
            return 0;
        }*/
        static void Main(string[] args)
        {
            Temperatury t = new Temperatury();
            t.Dodaj("Warszawa", 17.67);
            t.Dodaj( "Kraków", 19.32);
            t.Dodaj( "Wrocław", 22.31);
            t.Dodaj( "Katowice", 17.77);
            t.Dodaj( "Rzeszów", 24.16);
            t.Dodaj( "Poznań", 19.86);

            t.TmpMniejNiz20();
            t.SredniaTmp();
            t.TmpNizszaNizPoznan();
            t.MaxTmp();
            t.MinTmp();
            t.Sortowanie();
        }
    }
}
