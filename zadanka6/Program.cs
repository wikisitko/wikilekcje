using System;
using System.Collections.Generic;

namespace zadanka6
{
    enum TypZnaku { Samogloska, Spolgloska, Spacja };
    class Program
    {

        static void RysujZad1a(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
        static void Zadanie1a()
        {
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                RysujZad1a(i);
            }

        }
        static void RysujZad1b(int start, int ileRazy)
        {
            for (int i = 0; i < ileRazy; i++)
            {
                Console.Write(start + " ");
                start += 3;
            }
            Console.WriteLine();
        }

        static void Zadanie1b()
        {
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                RysujZad1b((i - 1) * 3, i);
            }

        }

        static void RysujZad1c(int start, int ileRazy)
        {
            for (int i = start; i < start * ileRazy; i++)
            {
                Console.Write((start + " "));
                i = start + i;

            }
            Console.WriteLine();
        }
        static void Zadanie1c()
        {
            int h = int.Parse(Console.ReadLine());
            for(int i = 1; i <= h; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write((i * j) + " ");
                }
                Console.WriteLine();
            }
        }

        static void Zadanie1d()
        {
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                int a = (int)Math.Pow(2, i);
                for (int j = 0; j < i; j++)
                {
                    Console.Write((a + j) + ",");
                }
                Console.WriteLine();
            }
        }

        static double[] Losuj(int rozmiar)
        {
            Random rand = new Random();
            double[] tablica = new double[rozmiar];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rand.NextDouble() + rand.Next(0, 11);
            }
            rand.NextDouble();
            return tablica;
        }
        static void Zadanie2()
        {
            var tab = Losuj(10);

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        static List<string> CzescWspolna(List<string> list1, List<string> list2)
        {
            List<string> wspolna = new List<string>();

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j] && !wspolna.Contains(list1[i]))
                    {
                        wspolna.Add(list1[i]);
                    }
                }
            }
            return wspolna;
        }

        static void Zadanie3()
        {
            List<string> list1 = new List<string>() { "Ada", "Ola", "Ania" };
            List<string> list2 = new List<string>() { "Ada", "Ola", "Marta" };


            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            //string[] names = new string[];

            string[] names1 = line1.Split(", ");
            string[] names2 = line2.Split(", ");

            list1.AddRange(names1);
            list2.AddRange(names2);

            //for (int i = 0; i < list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}
            //nie dziala grrrr

            var wspolna = CzescWspolna(list1, list2);

            for (int i = 0; i < wspolna.Count; i++)
            {
                Console.WriteLine(wspolna[i]);
            }

        }

        enum ZnakTyp { Spacja, Samogloska, Spolgoska };
        static ZnakTyp TypZnaku (char znak)
        {
            string samogloski = "aeiouy";
            ZnakTyp info;
            if(samogloski.Contains(znak) || samogloski.ToUpper().Contains(znak))
            {
                info = ZnakTyp.Samogloska;
            }
            else if (znak == ' ')
            {
                info = ZnakTyp.Spacja;
            }
            else
            {
                info = ZnakTyp.Spolgoska;
            }

            return info;
             
        }
            
        static void Zadanie4()
        {
            char a = char.Parse(Console.ReadLine());
            ZnakTyp wynik = TypZnaku(a);
            Console.WriteLine(wynik);
            if(wynik == ZnakTyp.Spolgoska)
            {
                Console.WriteLine("To jest spolgloska!");
            }
        }

        static string Zamien(string wejscie, int a, int b)
        {
            string nowy = "";
            //string nowy = "";

            for (int i = 0 ; i < a; i++)
            {
                nowy = nowy + wejscie[i];
            }

            for (int i = a; i <= b; i++)
            {
                if (wejscie[i] == 'R')
                {
                    nowy += "A";
                    //wejscie[i].ToString().Replace('R', 'A');
                    //wejscie.Remove(i, 1).Insert(i, "A");
                }
                else
                {
                    nowy += "R";
                    //wejscie[i].ToString().Replace('A', 'R');
                    //wejscie.Remove(i, 1).Insert(i, "R");
                }                    
            }
           
            for (int i = b+1; i < wejscie.Length; i++)
            {
                nowy = nowy + wejscie[i];
            }
            return nowy;
        }
        static void ZadanieDodatkowe()
        {
            string zetony = "ARAARARR";
            zetony = Zamien(zetony, 0, 2);
            zetony = Zamien(zetony, 2, 5);
            Console.WriteLine(zetony);

        }

        
        static void Main(string[] args)
        {
            ZnakTyp typ = ZnakTyp.Spacja;
            if(typ == ZnakTyp.Spacja)
            {
                Console.WriteLine("OK");
            }

            switch (typ)
            {
                case ZnakTyp.Spacja:
                    Console.WriteLine("To jest spacja!");
                    break;
                case ZnakTyp.Samogloska:
                    Console.WriteLine("To jest samogloska!");
                    break;
                case ZnakTyp.Spolgoska:
                    Console.WriteLine("To jest spolgloska!");
                    break;
            }

            //Zadanie1d();
            ZadanieDodatkowe();
            Console.ReadLine();
        }
    }
}
