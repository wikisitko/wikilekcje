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

            if(nip.StartsWith("118"))
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
            //string wielkieLitery = "ABCDEFGHIJKLŁMNOPRSTUWXYZŻŹĄĘÓ";

            for (int i = 0; i < text.Length; i++)
            {
                //if (wielkieLitery.Contains(text[i]))
                if(Char.IsUpper(text[i]))
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
        
        static bool CzyIstnieje(int[] tab, int wartosc)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i]==wartosc)
                {
                    return true;
                }
                
            }
            return false;
        }
        static void Zadanie7() //nie wykombinowalam:<
        {
            int[] tablica = new int[6];

            

            for (int i = 0; i < tablica.Length; )
            {
                int a = Int32.Parse(Console.ReadLine());
                if(CzyIstnieje(tablica, a))
                {
                    Console.WriteLine("Podana wartość istnieje w tablicy");
                }
                else
                {
                    tablica[i] = a;
                    i++;
                }

            }

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
           
            
        }
        static void Zadanie8()
        {
            //1 - papier
            //2 - kamień
            //3 - nożyce
            Random rand = new Random();
            int symbol;
            int odp;
            do
            {
                string[] symbole = new string[] { "kamien", "papier", "nozyce" };
                Console.Write("Podaj numer symbolu: ");
                symbol = Int32.Parse(Console.ReadLine());
                odp = rand.Next(1, 4); //[1, 4)

                if (symbol == odp)
                {
                    Console.WriteLine($"Gracz podał: {symbole[symbol-1]}, komputer wylosował: {symbole[odp-1]}. Remis!");
                }
                else
                {
                    Console.WriteLine($"Gracz podał: {symbole[symbol - 1]}, komputer wylosował: {symbole[odp - 1]}. Przegrana!");
                }
            }
            while (symbol == odp);

        }

        static void Zadanie9() //nie umiem sprawdzic czy numerki sie nie powtarzaja
        {
            Random rand = new Random();
            int[] numerki = new int[6];
            int[] wylosowane = new int[6];
            int trafienia = 0;

            for (int i = 0; i < 6; i++)
            {
                numerki[i] = Int32.Parse(Console.ReadLine());
                wylosowane[i] = rand.Next(1, 42);
            }

            Console.Write("Wylosowano: ");

            Console.WriteLine(wylosowane.ToString());

            for (int i = 0; i < wylosowane.Length; i++)
            {
                Console.Write($"{wylosowane[i]} ");

                for (int j = 0; j < numerki.Length; j++)
                {
                    if(wylosowane[i] == numerki[j])
                    {
                        trafienia++;
                        break;
                    }
                }
            }

            Console.WriteLine($"\nIlość trafień: {trafienia}");
           

        }

        static void PodajIloscPosiadanej()
        {
            Console.Write("Podaj ilości posiadanej farby w kolejności R (red), Y (yellow), B (blue): ");

        }
        static void Zadanie10()
        {
            //1 - żółty -> 10L Y
            //2 - zielony -> 4L: 2L Y + 2L B,
            //3 - niebieski -> 5L B
            //4 - fioletowy -> 3L: 1,5L R + 1,5L B,
            //5 - czerwony -> 3L R,
            //6 - pomarańczowy -> 8L: 4L Y + 4L R
                                  
            //basic[0] - red,
            //basic[1] - yellow,
            //basic[2] - blue
            //jak to ubrać w słowa żeby było bardziej understable? 
            
            double[] basic = new double[3];
            for (int i = 0; i < basic.Length; i++)
            {
                basic[i] = Double.Parse(Console.ReadLine());
            }

            
            Console.Write("\nPodaj ilości potrzebne do pomalowania sal: ");

            
            double [] neededColor = new double[6]; //ilość farby
            for (int i = 0; i < 6; i++)
            {
                neededColor[i] = Double.Parse(Console.ReadLine());
            }

           
            basic[1] = basic[1] - neededColor[0] - (neededColor[1]/2) - (neededColor[5]/2);
            basic[0] = basic[0] - (neededColor[3] / 2) - neededColor[4] - (neededColor[5] / 2);
            basic[2] = basic[2] - (neededColor[1] / 2) - neededColor[2] - (neededColor[3] / 2);

            Console.WriteLine($"Pozostało czerwona: {basic[0]}, Żółta: {basic[1]}, Niebieska: { basic[2]}");
            Console.WriteLine("===============================================");

            for (int i = 0; i < basic.Length; i++)
            {
                if (basic[i] < 0)
                {
                    Console.WriteLine(Math.Sqrt(basic[i] * basic[i]));
                }

                else
                {
                    Console.WriteLine("0");
                }
            }
          

        }

        static void Main(string[] args)
        {
            Zadanie10();
            Console.ReadLine();
        }
    }
}
