using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanka15_Linq
{
    class Program
    {   
        static void Main(string[] args)
        {
            List<int> liczby = new List<int>();
            Console.WriteLine("Podaj 10 liczb całkowitych: ");

            for (int i = 0; liczby.Count < 10; i++)
            {
                int input = Int32.Parse(Console.ReadLine());
                liczby.Add(input);
                i++;
            }
            Console.WriteLine();
            //foreach (var item in liczby)
            //{
            //    Console.WriteLine(item);
            //}


            //Ilosc liczb ktore naleza do przedzialu 1-10
            int ile = liczby.Count(x => x >= 1 && x <= 10);
            Console.WriteLine(ile);

            //Parzyste
            List<int> parzyste = liczby.FindAll(x => x % 2 == 0);

            //Dodatnie
            if(liczby.All(x => x > 10))
            {
                Console.WriteLine("Wszystkie dodatnie");
            }
            else
            {
                Console.WriteLine("Nie wszystkie dodatnie");
            }
            //Mniejsza niz -10
            Console.WriteLine(liczby.Any(x => x < -10)); 
            



        }
    }
}
