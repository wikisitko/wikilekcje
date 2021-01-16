using System;
using System.Collections.Generic;

namespace DziedziczenieCwiczeniaLekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f1 = new Figura(3, 5);
            Kolo k1 = new Kolo(4, 5, 3);
            Prostokat p1 = new Prostokat(6, 7, 2, 4);
            Kolo k2 = new Kolo(8, 9, 1);

            List<Figura> listaFigur = new List<Figura>();
            listaFigur.Add(f1);
            listaFigur.Add(k1);
            listaFigur.Add(p1);
            listaFigur.Add(k2);

            int sumaPola = 0;
            for (int i = 0; i < listaFigur.Count; i++)
            {
                Console.WriteLine(listaFigur[i]);
                int pole = listaFigur[i].Pole();
                Console.WriteLine("Pole: " + pole);
                sumaPola += pole;
            }

            Console.WriteLine("Suma: " + sumaPola);

            Console.WriteLine();
            Figura test = k1;
            Console.WriteLine(test);

            Console.WriteLine("Hello World!");
        }
    }
}
