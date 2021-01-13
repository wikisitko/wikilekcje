using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;

namespace zadanka5
{
    class Program
    {
        static void Rysuj(int ile)
        {
            for (int i = 0; i < ile; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void Zadanie1() //poprawka
        {

            int input = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Rysuj(i);

            }
        }

        static void Zadanie2()
        {
            string zdanie = Console.ReadLine();
            //var zmiana = zdanie.Replace('i', 'a');

            //Console.WriteLine(zmiana);
            string nowy = "";
            for(int i = 0; i < zdanie.Length; i++)
            {
                if(zdanie[i] != 'i')
                {
                    nowy += zdanie[i];
                }
                else
                {
                    nowy += 'a';
                }
            }

            Console.WriteLine(nowy);
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
                if (!CzyIstnieje(tablica, a))
                {
                    tablica[i] = a;
                    i++;
                }
            }


            string wynik = "";
            for (int i = 0; i < tablica.Length; i++)
            {
                wynik += tablica[i].ToString() + " ";
            }
            File.WriteAllText("wynik.txt", wynik);

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    File.AppendAllText("wynikappend.txt", tablica[i].ToString() + " ");
            //}


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
                a = rand.Next(0, tablica.Length);
                b = rand.Next(0, tablica.Length);

                zmienna =tablica[a];
                tablica[a] = tablica[b];
                tablica[b] = zmienna;
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

        static bool Palindrom(string slowo)
        {
            for (int i = 0; i < slowo.Length/2; i++)
            {
                if (slowo[i] != slowo[slowo.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Najdluzsze(string slowo)
        {
            
        }
        static void Zadanie5()
        {
            string path = @"C:\Users\Wiktoria Sitko\Documents\GitHub\wikilekcje\zadanka5\slowa.txt";
            //var wyrazy = File.ReadAllLines(path);
            var wyrazy = File.ReadAllText(path).Split("\r\n");

            Console.WriteLine("Palindrom: ");
            for (int i = 0; i < wyrazy.Length; i++)
            {
                if(Palindrom(wyrazy[i]))
                {
                    Console.WriteLine(wyrazy[i]);
                }
            }

            string najdluzszy = "";
            for (int i = 0; i < wyrazy.Length; i++)
            {
                if (najdluzszy.Length < wyrazy[i].Length)
                {
                    najdluzszy = wyrazy[i];
                }
            }
            Console.WriteLine($"Najdłuższy wyraz to: {najdluzszy}");  //nie dziala xD

            for (int i = 0; i < wyrazy.Length; i++)
            {
                if (wyrazy[i].StartsWith('a') && wyrazy[i].EndsWith('a'))
                {
                    Console.WriteLine($"Starts and ends: {wyrazy[i]}");
                }
            }

            //string wybraneSlowo = "kamilslimak";

            //Palindrom(wybraneSlowo);

        }



        static void Zadanie6()
        {
            string[] linie = File.ReadAllLines(@"..\..\..\R&D.csv", System.Text.Encoding.UTF8);
            Dane dane = new Dane();
            for (int i = 1; i < linie.Length; i++)
            {
                var wartosci = linie[i].Split(",");
                InfoWydatki info = new InfoWydatki(wartosci[0], int.Parse(wartosci[1]),
                    double.Parse(wartosci[2], CultureInfo.InvariantCulture),
                    double.Parse(wartosci[3], CultureInfo.InvariantCulture),
                    double.Parse(wartosci[4], CultureInfo.InvariantCulture));
                dane.DodajInfo(info);
            }

            dane.Pokaz();

            
            Console.WriteLine();
            dane.MniejNiz2Mln();

            Console.WriteLine();
            dane.ProcPodmioty();

            Console.WriteLine();
            dane.PodmiotyMinMax();

            Console.WriteLine();
            Console.WriteLine($"Min {dane.InwestycyjneMin()}");

        }

        static void Zadanie7()
        {
            string liczby = Console.ReadLine();
            string[] tab = liczby.Split(" ");
            //int[] tablica = new int[liczby.Length];
            int n = tab.Length;

            bool zawiera = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (int.Parse(tab[i]) != j)
                    {
                        zawiera = false;
                    }
                }
            }

            if (zawiera == true)
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
            Zadanie7();
            //for(int i = 0; i < 100; i++)
            //{
            //    Console.Write(i + "_____\r");
            //    Thread.Sleep(1000);
            //}
            //Console.ReadLine();
        }
    }
}
