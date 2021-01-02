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
                Console.WriteLine();
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

        static void Zadanie3() //przypomnnieć żebyś pokazał alternatywny sposób
        {
            Random rand = new Random();
            //Utworz tablice i wpisz tam wartosci od 0 do 20
            //wykonaj w petli 100 razy nastepujace kroki
            //>>>wylosuj index A
            //>>>wylosuj index B
            //>>>przestaw miejscami wartosci pod indeksami A i B
            //wyswietl pierwsze 6 wartosci z tablicy
        }

        static void Main(string[] args)
        {
            Zadanie1();
            Console.ReadLine();
        }
    }
}
