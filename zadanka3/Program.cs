﻿using System;
using System.Linq;

namespace zadanka3
{
    class Program
    {
       
        static void Zadanie1()
        {
            Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = Int32.Parse(Console.ReadLine());

            for (int i = b; i >= a; i--)
            {
                Console.WriteLine(i);
            } 
        }

        static void Zadanie2()
        {
            Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }

        static void Zadanie3()
        {
            Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = Int32.Parse(Console.ReadLine());

            int s = 0;

            for (int i = a; i <= b; i++)
            {
                s += i;
            }
            Console.WriteLine(s);
        }

        static void Zadanie4() //poprawka
        {
            Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = Int32.Parse(Console.ReadLine());
            int s = 1;
            int i = 1;

            
            for (i = a; i <= b; i++) //s ma byc mniejsze od 1000
            {
                s = s * i;
                Console.WriteLine(i);
            }

            Console.WriteLine(i);
        }

        static void Zadanie5() //poprawka
        {

        }

        static void Zadanie6()
        {
            Console.Write("Podaj x: ");
            int odpowiedz = Int32.Parse(Console.ReadLine());
            int wynik = 0;

            while (odpowiedz != 0)
            {
                wynik += (odpowiedz % 10);
                odpowiedz /= 10;
            }

            Console.WriteLine(wynik);
        }

        static void Zadanie7()
        {
            int wartosc = 0;
            int liczba;

            do
            {
                Console.Write("Podaj liczbę: ");
                liczba = Int32.Parse(Console.ReadLine());
                wartosc += 1;
            }
            while (liczba != 0);

            Console.WriteLine(wartosc);
        }

        static void Zadanie8()
        {
            Random rnd = new Random();
            int wylosowana = rnd.Next(0, 21);
            int odpowiedz;

            do
            {
                Console.Write("Podaj liczbe: ");
                odpowiedz = Int32.Parse(Console.ReadLine());

                if (odpowiedz > wylosowana)
                {
                    Console.WriteLine("Za duża!");
                }

                else if (odpowiedz < wylosowana)
                {
                    Console.WriteLine("Za mała!");
                }

                else
                {
                    Console.WriteLine("Spoczko");
                }
            }
            while (wylosowana != odpowiedz);
        }

        static void Zadanie9()
        {
            int wartosc = 0;

            Console.Write("1: ");
            int first = Int32.Parse(Console.ReadLine());

            if (first % 3 == 0)
            {
                wartosc += 1;
            }

            Console.Write("2: ");
            int second = Int32.Parse(Console.ReadLine());

            if (second % 3 == 0)
            {
                wartosc += 1;
            }

            Console.Write("3: ");
            int third = Int32.Parse(Console.ReadLine());

            if (third % 3 == 0)
            {
                wartosc += 1;
            }

            Console.Write("4: ");
            int fourth = Int32.Parse(Console.ReadLine());

            if (fourth % 3 == 0)
            {
                wartosc += 1;
            }

            Console.Write("5: ");
            int fifth = Int32.Parse(Console.ReadLine());

            if (fifth % 3 == 0)
            {
                wartosc += 1;
            }

            Console.WriteLine(wartosc);
        }

        static void Zadanie10() //poprawka -- w dobrą stronę:)
        {
            int i;
            
            Console.Write("Podaj ile liczb: ");
            int ileLiczb = Int32.Parse(Console.ReadLine());

            int[] Liczby = new int[ileLiczb];

            for (i = 0; i < ileLiczb; i++)
            {
                Liczby[i] = Int32.Parse(Console.ReadLine());

            }

            if (Liczby[i] <= Liczby[i + 1])
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }


        }

        static void Zadanie11()
        {
            int[] tablica = new int[5];

            for (int j = 0; j <= 4; j++)
            {
                Console.Write($"Podaj {j+1} wartość: ");
                tablica [j] = Int32.Parse(Console.ReadLine());
            }
            
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }
        }

        static void Zadanie12() //ok ale za duze liczby
        {
            Random rand = new Random();
            int rozmiarTablicy = Int32.Parse(Console.ReadLine());

            long[] tablica1 = new long[rozmiarTablicy];

            for (int i = 0; i < rozmiarTablicy; i++)
            {
                tablica1[i] = rand.Next();
                Console.Write(tablica1[i] + " ");
            }

            Console.WriteLine("\n \n");

            long[] tablica2 = new long[rozmiarTablicy];

            for (int i = 0; i < rozmiarTablicy; i++)
            {
                tablica2[i] = rand.Next();
                Console.Write(tablica2[i] + " ");
            }

            Console.WriteLine("\n \n");
            
            for (int i = 0; i < rozmiarTablicy; i++)
            {
                Console.Write(tablica2[i] + tablica1[i] + " ");
            }


        }

        static void Zadanie13() //mediana no idea
        {
            double srednia = 0;
            int i;
            int ileLiczb = Int32.Parse(Console.ReadLine());

            int[] tablicaLiczb = new int[ileLiczb];

            for (i = 0; i < ileLiczb; i++)
            {
                tablicaLiczb[i] = Int32.Parse(Console.ReadLine());
                srednia += tablicaLiczb[i];
            }

            Console.WriteLine($"Średnia to: {srednia/ileLiczb}");

            

        }

        static void Zadanie14()//????????
        {
            string tekst = Console.ReadLine();
            int count = 0;

            Console.WriteLine($"Długość tekstu to: {tekst.Length}");

            string[] tablicaZnakow = new string[tekst.Length];

            char[] tablicaSamoglosek = { 'a', 'e', 'i', 'o', 'u' };

            if (tekst.Contains('a'))
            {
                count++;
            }
            else
            {

            }
            Console.WriteLine(count);

        }

        static void Main(string[] args)
        {
            //data lekcji, data zapalty, kto, cena
            //17-12-2020, ping, Wiktoria, 80
            //16-12-2020, 16-12-2020, Ada, 80

            Zadanie14();

            Console.ReadLine();
        }

    }
}
