using System;

namespace zadanka4
{   
    class Program
    {
        static void Zadanie1()
        {
            DateTime d1 = DateTime.Now;
           
            Console.Write("Podaj datę urodzenia: ");
            string birthDate = Console.ReadLine();

            DateTime d2;
            DateTime.TryParse(birthDate, out d2);


            if (d1.Year - d2.Year >= 18)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
        }

        static void Zadanie2() //trzeba skrócić


        {
            Console.Write("Podaj NIP: ");

            string nip = Console.ReadLine();

            if(nip[0] == '1' && nip[1] == '1' && nip[2] == '8')
            {
                Console.WriteLine("Warszawa-Bielany");
            }

            else if(nip[0] == '1' && nip[1] == '1' && nip[2] == '7')
            {
                Console.WriteLine("Warszawa-Wola");
            }

            else if (nip[0] == '1' && nip[1] == '1' && nip[2] == '1')
            {
                Console.WriteLine("Warszawa-Mokotów");
            }

            else
            {
                Console.WriteLine("Nie wiem");
            }
        }

        static void Zadanie3()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Wiktoria Sitko\Documents\GitHub\wikilekcje\zadanka4\dane.txt");

            //Console.WriteLine(text);
            int count = 0;
            string wielkieLitery = "ABCDEFGHIJKLŁMNOPRSTUWXYZŻŹĄĘÓ";

            for (int i = 0; i < text.Length; i++)
            {
                if (wielkieLitery.Contains(text[i]))
                {
                    count++;
                }

            }

            Console.WriteLine($"Ilość wielkich liter to: {count}");
        }

        static void Zadanie4()
        {
            Random rand = new Random();
            
            int[] liczby = new int[10];
            for (int i = 0; i < 10; i++)
            {
                 
                liczby[i] = 2* rand.Next(0,100);
                             
                Console.WriteLine(liczby[i]);
            }
                       
        }
        static void Zadanie5()
        {
            Random rand = new Random();
            int[] tablica = new int[10];

            for (int i = 0; i < 10; i++)
            {
                tablica[i] = rand.Next(0, 10);
                Console.Write($"{tablica[i]} ");
            }

            Console.Write("\n\nPodaj indeks początkowy: ");
            int przedzialA = Int32.Parse(Console.ReadLine());
            Console.Write("\n\nPodaj indeks końcowy: ");
            int przedzialB = Int32.Parse(Console.ReadLine());

            int x = 0;
            for (int j = przedzialA; j <= przedzialB; j++)
            {
                x += tablica[j];
            }

            Console.WriteLine($"\n\nSuma elementów: {x}");
        }
        static void Zadanie6()
        {
            Console.Write("Ile liczb wylosować? ");
            int ileLiczb = Int32.Parse(Console.ReadLine());

            int[] tablicaLiczb = new int[ileLiczb];
            Random rand = new Random();

            Console.Write("Wylosowano: ");
            for (int i = 0; i < ileLiczb; i++)
            {
                tablicaLiczb[i] = rand.Next(0, 20);
                Console.Write(tablicaLiczb[i] + " ");
            }
            
            Console.Write("\n\nPodaj indeks A: ");
            int indeksA = Int32.Parse(Console.ReadLine());
            Console.Write("\n\nPodaj indeks B: ");
            int indeksB = Int32.Parse(Console.ReadLine());

            int tmp = tablicaLiczb[indeksA];
            tablicaLiczb[indeksA] = tablicaLiczb[indeksB];
            tablicaLiczb[indeksB] = tmp;


            Console.Write("Po zmianie: ");
            for (int i = 0; i < ileLiczb; i++)
            {
                Console.Write(tablicaLiczb[i] + " ");
            }

        }
        
        static void Zadanie7()
        {
            int[] tablica = new int[6];

            for (int i = 0; i < 6; i++)
            {

            }
            Console.Write("Podaj liczbę: ");
            tablica[0] = Int32.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę: ");
            tablica[1] = Int32.Parse(Console.ReadLine());

            if (tablica[1] == tablica[0])//if (tablica i == tablica i-1
            {
                Console.WriteLine("Wprowadzona liczba już istnieje, podaj inną.");
            }
            Console.Write("Podaj liczbę: ");
            tablica[1] = Int32.Parse(Console.ReadLine());




        }

        static void Main(string[] args)
        {
            Zadanie6();
            Console.ReadLine();
        }
    }
}
