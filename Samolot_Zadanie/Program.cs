using System;
using System.Collections.Generic;

namespace Samolot_Zadanie
{
    class Program
    {
        //static bool Sprawdz(List<ICzujnik> name)
        //{
        //    foreach (var item in name)
        //    {
        //        if (Alarm() == true)
        //        {
        //            return true;
        //        }
        //    }
            
        //}
        static void Main(string[] args)
        {
            List<ICzujnik> urzadzenia = new List<ICzujnik>();
            urzadzenia.Add(new Silnik(1000, 4));
            urzadzenia.Add(new RurkaPitota("19/02/2015", 3));
            //urzadzenia.Add(new APU(true));

            

            //if(Sprawdz(urzadzenia))
            //{
            //    Console.WriteLine("Alarm!");
            //}


        }
    }
}
