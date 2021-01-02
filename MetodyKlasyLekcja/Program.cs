using System;
using System.IO;

namespace MetodyKlasyLekcja
{
    class Program
    {
        static void funkcja(int ilosc, string text)
        {
            for (int i = 0; i < ilosc; i++)
            {
                Console.WriteLine(text);
            }
            
        }

        static void pokaz(int[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
        
        static int suma(int a, int b)
        {
            int wynik = a + b;
            return wynik;
        }

        static int ileJedynek(int[] tab)
        {
            int licznik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if(tab[i] == 1)
                {
                    licznik++;
                }
            }
            return licznik;
        }

        static void Main(string[] args)
        {
            //funkcja(7, "test");
            //funkcja(3, "ok");
            //int[] tablica = new int[] { 5, 10, 9, 1, 5, 1, 50, 11, 8 };
            // pokaz(tablica);
            //Console.WriteLine(ileJedynek(tablica));
            //int w = suma(9, 5);
            //Console.WriteLine(w);



            
            Osoba[] osoby = ZaladujOsoby(@"C:\Users\Wiktoria Sitko\Desktop\dane.csv");
            WyswietlOsoby(osoby);
            ZapiszWynikOsoby(osoby, @"C:\Users\Wiktoria Sitko\Desktop\wynik.csv");
            


            Console.ReadLine();
        }

        static void WyswietlOsoby(Osoba[] osoby)
        {
            for (int i = 0; i < osoby.Length; i++)
            {
                Console.WriteLine(osoby[i]);
            }
        }

        static Osoba[] ZaladujOsoby(string nazwaPliku)
        {
            var linie = File.ReadAllLines(nazwaPliku);
            Osoba[] osoby = new Osoba[linie.Length];
            for (int i = 0; i < osoby.Length; i++)
            {
                var linia = linie[i].Split(";");
                Osoba os = new Osoba(linia[0], linia[1], int.Parse(linia[2]));
                osoby[i] = os;
            }
            return osoby;
        }

        static void ZapiszWynikOsoby(Osoba[] osoby, string nazwaPliku)
        {
            string wynik = "";
            for (int i = 0; i < osoby.Length; i++)
            {
                if (osoby[i].Ocena == 4)
                {
                    string liniaCsv = osoby[i].ToCsv();
                    wynik += liniaCsv;
                }
            }
            File.WriteAllText(nazwaPliku, wynik);
        }
    }
}
