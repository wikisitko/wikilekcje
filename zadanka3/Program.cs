using System;

namespace zadanka3
{
    class Program
    {
        #region Zadanie1
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
        #endregion

        static void Main(string[] args)
        {
            ////ZADANIE1
            //Zadanie1();
            

            ////ZADANIE 2
            /*Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }*/

            ////ZADANIE 3
            /*Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = Int32.Parse(Console.ReadLine());

            int s = 0;

            for (int i = a; i <= b; i++)
            {
                s += i;                
            }
            Console.WriteLine(s); */

            ////ZADANIE 4 - może jeszcze wymyślę...
            /*Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = Int32.Parse(Console.ReadLine());
            int s = 1;

            for (int i = a; i <= b; i++)
            {

                do
                {
                    s = s * i;
                }
                while (s < 1000);

                Console.WriteLine(s);
            } */

            ////ZADANIE 5
            ////ZADANIE 6
            /*
            Console.Write("Podaj x: ");
            int odpowiedz = Int32.Parse(Console.ReadLine());
            int wynik = 0;

            while (odpowiedz!=0)
            {
                wynik += (odpowiedz % 10);
                odpowiedz /= 10;
            }

            Console.WriteLine(wynik); */


            ////ZADANIE 7
            /*
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

            */

            ////ZADANIE 8
            /*
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

           */


            ////ZADANIE 9

            /* int wartosc = 0; 

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

             if (fifth%3==0)
             {
                 wartosc += 1;
             }

             Console.WriteLine(wartosc);
            */

            ////ZADANIE 10
            ////ZADANIE 11

            /*
            int[] tablica = new int[5];

            Console.Write("Podaj pierwszą wartość: ");
            tablica[0] = Int32.Parse(Console.ReadLine());

            Console.Write("Podaj drugą wartość: ");
            tablica[1] = Int32.Parse(Console.ReadLine());

            Console.Write("Podaj trzecią wartość: ");
            tablica[2] = Int32.Parse(Console.ReadLine());

            Console.Write("Podaj czwartą wartość: ");
            tablica[3] = Int32.Parse(Console.ReadLine());

            Console.Write("Podaj piątą wartość: ");
            tablica[4] = Int32.Parse(Console.ReadLine());

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }
            */

            ////ZADANIE 12
            /*
            int rozmiarTablicy = Int32.Parse(Console.ReadLine());

            int[] tablica = new int [rozmiarTablicy];
            */

            //data lekcji, data zapalty, kto, cena
            //17-12-2020, ping, Wiktoria, 80
            //16-12-2020, 16-12-2020, Ada, 80

            DateTime

            Console.ReadLine();
        }

    }
}
