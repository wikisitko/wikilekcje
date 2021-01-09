using System;
using System.Collections.Generic;

namespace ListyLekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liczby = new List<int>() { 5, 6, 10, 11, 100, 1 };
            liczby.Add(9);
            liczby.Add(8);
            liczby[0] = -1;

            for (int i = 0; i < liczby.Count; i++)
            {
                Console.Write(liczby[i] + " ");
            }
            Console.WriteLine();

            //liczby.Remove(100);
            liczby.RemoveAt(1);

            for (int i = 0; i < liczby.Count; i++)
            {
                Console.Write(liczby[i] + " ");
            }
            Console.WriteLine();

            if(liczby.Contains(11))
            {
                Console.WriteLine("11 istnieje");
            }

            liczby.Sort();
            liczby.Reverse();

            foreach (var num in liczby)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
