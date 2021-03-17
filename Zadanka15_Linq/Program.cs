using System;
using System.Collections.Generic;

namespace Zadanka15_Linq
{
    class Program
    {   
        static void PodajLiczby()
        {
            List<int> liczby = new List<int>();
            Console.WriteLine("Podaj 10 liczb całkowitych: ");

            string input = Console.ReadLine();
            
            for (int i = 0; i < liczby.Count; i++)
            {
                liczby[i] = input[i];
            }
        }
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
            foreach (var item in liczby)
            {
                Console.WriteLine(item);
            }


        }
    }
}
