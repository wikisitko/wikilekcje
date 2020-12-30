using System;
using System.Globalization;
using System.IO;

namespace StringLekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj dwie liczby?");
            //string linia = Console.ReadLine();
            //string[] liczbyStr = linia.Split(" ");
            //int a = int.Parse(liczbyStr[0]);
            //int b = int.Parse(liczbyStr[1]);
            //Console.WriteLine($"{a} {b}");

            string path = @"C:\Users\Wiktoria Sitko\Desktop\dane2.txt";
            //string data = File.ReadAllText(path);
            //string[] liczbyStr = data.Split(" ");
            //int[] tab = new int[liczbyStr.Length];
            //for (int i = 0; i < liczbyStr.Length; i++)
            //{
            //    tab[i] = int.Parse(liczbyStr[i]);
            //}

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    Console.WriteLine(tab[i]);
            //}

            //Wczytywanie wartosci liczbowych linia po linii
            //string[] linie = File.ReadAllLines(path);
            //for(int i = 0; i < linie.Length; i++)
            //{
            //    string[] liczbyStr = linie[i].Split(" ");
            //    int[] tab = new int[liczbyStr.Length];
            //    for (int j = 0; j < liczbyStr.Length; j++)
            //    {
            //        tab[j] = int.Parse(liczbyStr[j]);
            //    }

            //    for (int j = 0; j < tab.Length; j++)
            //    {
            //        Console.WriteLine(tab[j]);
            //    }
            //}

            //Wczytywanie pliku csv i wyciaganie danych

            string csvPath = @"C:\Users\Wiktoria Sitko\Desktop\FL_insurance_sample.csv";
            var lines = File.ReadAllLines(csvPath);
            const int N = 500;
            var countries = new string[N];
            var values = new double[N];
            for (int i = 1; i < N; i++)
            {
                //Console.WriteLine(lines[i]);
                //dzielimy pojedyncza linie na kolumny
                var items = lines[i].Split(",");
                //wycigamy wartosc z kolumny nr 2
                string country = items[2];
                double value = double.Parse(items[3], CultureInfo.InvariantCulture);
                //Console.WriteLine($"{country} {value}");
                countries[i-1] = country;
                values[i-1] = value;
            }

            int k = 0;
            for (int i = 0; i < N; i++)
            {
                if(values[i] == 0)
                {
                    Console.WriteLine($"{k++}. {countries[i]}");
                }
            }

            Console.ReadKey();
        }
    }
}
