using System;
using System.Collections.Generic;
using System.IO;

namespace zadanka7
{
    class Program
    {

        //static string Zadanie1(string napis, int liczba)
        //{
            

        //    string zmiana;


        //     return (zmiana);
        //}

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
                if (!lista.Contains(wyraz)) //if (imie != wyraz)
                {
                    lista2.Add(imie);
                }

            }

            Console.WriteLine(lista2);
            return (lista2);
        }

        static int Zadanie3(string nazwa)
        {
            var plik = File.ReadAllText(@"C:\Users\Wiktoria Sitko\Documents\GitHub\wikilekcje\zadanka4\" + nazwa);

            Console.WriteLine(plik.Length);
            return(plik.Length);

        }

        static int[] Zadanie4(int[] tablica, int number)
        {
            int[] tab1 = new int[tablica.Length];

            for (int i = 0; i<tablica.Length; i++)
            {
                if(tablica[i]<number)
                {
                    tab1[i] = tablica[i];
                }
            }

            return (tab1);
        }

        static void Zadanie5()
        {
            int length = Int32.Parse(Console.ReadLine());
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            string wyraz;

            for (int i = 0; i < length; i++) 
            {
                
            }


        }
        static void Main(string[] args)
        {
            List<string> imiona = new List<string>();

            imiona.Add("Asia");
            imiona.Add("Basia");
            imiona.Add("Ola");
            imiona.Add("Zosia");
            imiona.Add("Ola");
            imiona.Add("Kasia");

            Zadanie2(imiona, "Ola");
            Console.WriteLine("Hello World!");
        }
    }
}
