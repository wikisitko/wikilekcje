using System;
using System.Collections.Generic;

namespace FunkcjeRozszerzajaceNullable_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var lista = rand.Losuj(5);
            lista.Show();

            new Random().Losuj(30).Show();

            Ticket t = new Ticket("nie dziala", 1);
            //int a = null;
            //DateTime d = null; //nie da sie tak zrobic bo datetime nie jest typem referencyjnym jak np Klasy czy Tablice
            //jak to naprawic?
            DateTime? data = null;
            int? liczba = null;

            DateTime dd = new DateTime(2020, 10, 15);
            DateTime xx = dd; //datetime jest typem niereferencyjnym wiec tutaj dojdzie do stworzenia nowego obiektu klasy datetime do ktore zostana skopiowane wartosci z dd
            Console.WriteLine(dd);
            Console.WriteLine(xx);
            //typy niereferencyjne - typy proste (int, double, bool, char) i struktury (struct)

            Punkt p = new Punkt(5, 7);
            Punkt p2 = p; //tutaj doszlo do skopiowania obiektu (stworzyl sie drugi w pamieci ktory jest kopia pierwszego)
            p2.y = 15;

            Console.WriteLine(p);
            Console.WriteLine(p2);

            //Punkt? p3 = new Punkt(9, 8);
            //Punkt? p4 = p3;
            //p3.Value.Zeruj();

            //Console.WriteLine(p3);
            //Console.WriteLine(p4);
        }
    }
}
