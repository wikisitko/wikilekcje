using System;
using System.Collections.Generic;
using System.IO;

namespace zadanka7
{
    class Program
    {

        static string Zadanie1(string napis, int liczba)
        {
            string zmiana  = "";
            for(int i = 0; i < napis.Length; i++)
            {
                if((i+1) % liczba == 0)
                {
                    zmiana += "*";
                }
                else
                {
                    zmiana += napis[i];
                }

            }

            return zmiana;
        }

        static List<string> Zadanie2(List<string> lista, string wyraz)
        {
            List<string> lista2 = new List<string>();

            //for (int i = 0; i < lista.Count; i++)
            //{
            //    if(!lista[i].Contains(wyraz))
            //    {
            //        lista2.Add(lista[i]);
            //    }
            //}

            foreach (var imie in lista)
            {
                if (imie != wyraz)
                {
                    lista2.Add(imie);
                }

            }

            return (lista2);
        }

        static int Zadanie3(string nazwa)
        {
            var plik = File.ReadAllText(@"C:\Users\Wiktoria Sitko\Documents\GitHub\wikilekcje\zadanka4\" + nazwa);
            return(plik.Length);
        }

        static int[] Zadanie4(int[] tablica, int number)
        {
            int ileMniejszych = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] < number)
                {
                    ileMniejszych++;
                }
            }

            int[] tab1 = new int[ileMniejszych];

            int k = 0;
            for (int i = 0; i<tablica.Length; i++)
            {
                if(tablica[i]<number)
                {
                    tab1[k] = tablica[i];
                    k++;
                }
            }

            return (tab1);
        }

        static int[] Zadanie4b(int[] tablica, int number)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] < number)
                {
                    lista.Add(tablica[i]);
                }
            }

            return lista.ToArray();
        }

        static string Zadanie5(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            string wyraz = "";

            for (int i = 0; i < length; i++) 
            {
                var indeks = rand.Next(0, chars.Length);
                wyraz += chars[indeks];
            }

            return wyraz;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Zadanie1("wiktoria", 2));
            List<string> imiona = new List<string>();

            imiona.Add("Asia");
            imiona.Add("Basia");
            imiona.Add("Ola");
            imiona.Add("Zosia");
            imiona.Add("Ola");
            imiona.Add("Kasia");

            List<string> wynik = Zadanie2(imiona, "Ola");
            foreach (var item in wynik)
            {
                Console.WriteLine(item);
            }

            int iloscZnakow = Zadanie3("dane.txt");
            Console.WriteLine(iloscZnakow);

            Console.WriteLine("--------------------");
            var tab = Zadanie4(new int[] { 5, 10, 5, 4, 10, 8, 7, 10 }, 6);
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Zadanie5(20));
        }
    }
}
