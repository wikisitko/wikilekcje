﻿using System;
using System.Collections.Generic;

namespace zadanie_Koszyk
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Telefon t1 = new Telefon("Samsung","A30", 100);
            Telefon t2 = new Telefon("Samsung", "A40", 1000);
            Telefon t3 = new Telefon("Samsung", "A50", 10000);
            Telefon t4 = new Telefon("Samsung", "A60", 100000);


            List<Telefon> ListaTelefonow = new List<Telefon>();
            ListaTelefonow.Add(t1);
            ListaTelefonow.Add(t2);
            ListaTelefonow.Add(t3);
            ListaTelefonow.Add(t4);


           

            Console.WriteLine("Hello World!");
        }
    }
}
