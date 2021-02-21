using System;

namespace Wyjatki_Lekcja
{
    class Program
    {
        public static void Show(int[] tab, int a, int b)
        {
            if(b > a)
            {
                //rzut wyjatkiem - przerywa ta funkcje oraz inne funkcje ktore wywolaly ta dopki nie natrafi na blok try
                throw new ZlyPrzedzialException();
            }

            for (int i = a; i <= b; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            

            int[] tablica = new int[100];

            Console.WriteLine("Podaj index" );
           

            //otaczamy kod podejrzewany o rzucenie wyjatkiem + linie ktore bezposrednio wynikaja z tego kodu
            //jesli w bloku try wystapi wyjatek ktory jest okreslony w bloku catch to przerywa sie wykonanie bloku try i przechodzi do catch
            //jesli w catch nie ma obslugiwanego tego wyjatku to ostaje przerwana dana funkcja, jesli to dotyczy main to program sie konczy
            try
            {
                int index = int.Parse(Console.ReadLine()); // ta tez 
                int wartosc = tablica[index]; //ta instrukcja moze generowc blad
                //jesli w linii tablica[index] wystapi wyjatek to ponizsza linia nigdy sie nie wykona i skoczymy do catch
                Console.WriteLine($"Wartosc pod indeksem {index} wynosi: {wartosc}"); //ta instrukcja bazuje na powodzeniu poprzedniej instrukcji
                Show(tablica, 0, 10);
                Show(tablica, 10, 0);
            }
            catch(IndexOutOfRangeException ex) //IndexOutOfRangeException - systemowa klasa wyjatku ale tez mozemy je robic sami, ex - zmienna ktora trzyma dodatkowe informacje o wyjatku
            {
                Console.WriteLine("Podano niepoprawny index!");
                Console.WriteLine($"Wyjatek {ex}");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Wprowadz liczbe!");
                Console.WriteLine($"Wyjatek {e}");
            }
            catch(ZlyPrzedzialException ze)
            {
                Console.WriteLine("Zly przedzial");
                Console.WriteLine(ze);
            }

            

            Console.WriteLine("Program OK");
        }
    }
}
