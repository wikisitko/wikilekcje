using System;
using System.IO;

namespace zadanka5
{
    class Program
    {
        static void Zadanie1() //poprawka
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
            var zmiana = zdanie.Replace('i', 'a');

            Console.WriteLine(zmiana);

        }


        static bool CzyIstnieje(int[] tab, int wartosc)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == wartosc)
                {
                    return true;
                }

            }
            return false;
        }
        static void Zadanie3() //przypomnnieć żebyś pokazał alternatywny sposób
        {
            Random rand = new Random();
            int[] tablica = new int[6];

            for (int i = 0; i < tablica.Length;)
            {
                int a = rand.Next(0, 21);
                if (CzyIstnieje(tablica, a))
                {

                }
                else
                {
                    tablica[i] = a;
                    i++;
                }
            }


            for (int i = 0; i < tablica.Length; i++)
            {
                File.WriteAllText("wynik.txt", tablica[i].ToString());
            }

            
            
        }

        static void Zadanie3a()
        {
            //Utworz tablice i wpisz tam wartosci od 0 do 20
            //wykonaj w petli 100 razy nastepujace kroki
            //>>>wylosuj index A
            //>>>wylosuj index B
            //>>>przestaw miejscami wartosci pod indeksami A i B
            //wyswietl pierwsze 6 wartosci z tablicy
            Random rand = new Random();
            int[] tablica = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            int a;
            int b;
            int zmienna;

            for (int i = 0; i < 100; i++)
            {
                a = tablica[rand.Next(0, 20)];
                b = tablica[rand.Next(0, 20)];

                zmienna = a;
                a = b;
                b = zmienna;
            }

            Console.Write("Pierwsze 6 wartości: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{tablica[i]}, ");
            }
            
        }

        static void Zadanie4()
        {
            string input = Console.ReadLine();
            
            string[] tab = input.Split(" ");
            int[] liczby = new int[tab.Length];
            

            for (int i = 0; i < tab.Length; i++)
            {
                liczby[i] = Int32.Parse(tab[i]);              
            }

            bool rosnacy = true;
            for (int i = 0; i < liczby.Length - 1; i++)
            {
                if (liczby[i]>liczby[i+1])
                {
                    rosnacy = false;
                    break;
                }
            }

            if (rosnacy)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }

        }
        static void Main(string[] args)
        {
            Zadanie4();
            Console.ReadLine();
        }
    }
}
