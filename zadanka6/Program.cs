using System;
using System.Collections.Generic;

namespace zadanka6
{
    class Program
    {

        static void RysujZad1a(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Zadanie1a()
        {
            int h = int.Parse(Console.ReadLine());
            for(int i = 1; i <= h; i++)
            {
                RysujZad1a(i);
            }
            
        }
        static void RysujZad1b(int start, int ileRazy)
        {
            for (int i = 0; i < ileRazy; i++)
            {
                Console.Write(start + " ");
                start += 3;
            }
            Console.WriteLine();
        }

        static void Zadanie1b()
        {
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                RysujZad1b((i-1)*3, i);
            }

        }
        static double[] Losuj(int rozmiar)
        {
            Random rand = new Random();
            double[] tablica = new double[rozmiar];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rand.NextDouble() + rand.Next(0, 11);
            }
            rand.NextDouble();
            return tablica;
        }
        static void Zadanie2()
        {
            var tab = Losuj(10);

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        static List<string> CzescWspolna(List<string> list1, List<string> list2)
        {
            List<string> wspolna = new List<string>();

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j] && !wspolna.Contains(list1[i]))
                    {
                        wspolna.Add(list1[i]);
                    }
                }
            }
            return wspolna;
        }

        static void Zadanie3()
        {
            List<string> list1 = new List<string>() { "Ada", "Ola", "Ania" };
            List<string> list2 = new List<string>() { "Ada", "Ola", "Marta" };


            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            //string[] names = new string[];

            string[] names1 = line1.Split(", ");
            string[] names2 = line2.Split(", ");

            list1.AddRange(names1);
            list2.AddRange(names2);

            //for (int i = 0; i < list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}
            //nie dziala grrrr

            var wspolna = CzescWspolna(list1, list2);

            for (int i = 0; i < wspolna.Count; i++)
            {
                Console.WriteLine(wspolna[i]);
            }

        }
        static void Main(string[] args)
        {
            Zadanie1b();
            Console.ReadLine();
        }
    }
}
