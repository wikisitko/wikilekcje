using System;

namespace zadanka5
{
    class Program
    {
        static void Zadanie1()
        {
            int input = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < input-1; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }

        static void Zadanie2()
        {
            string zdanie = Console.ReadLine();

            for (int i = 0; i < zdanie.Length; i++)
            {
                if (zdanie[i] == 'i')
                {
                    //??
                }
            }
        }

        static void Zadanie3()
        {
            Random rand = new Random();

        }

        static void Main(string[] args)
        {
            Zadanie1();
            Console.ReadLine();
        }
    }
}
