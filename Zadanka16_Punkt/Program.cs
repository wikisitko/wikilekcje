using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanka16_Punkt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Punkt> lista = new List<Punkt>();

            for (int i = 0; i < 100;)
            {
                Punkt p = new Punkt(rand.Next(-20, 20), rand.Next(-20, 20));
                lista.Add(p);
                i++;
            }

            //ile punktow w kazdej cwiartce ukladu
            int ilePierwsza = lista.Count(punkt => punkt.x > 0 && punkt.y > 0);
            int ileDruga = lista.Count(punkt => punkt.x < 0 && punkt.y > 0);
            int ileTrzecia = lista.Count(punkt => punkt.x < 0 && punkt.y < 0);
            int ileCzwarta = lista.Count(punkt => punkt.x > 0 && punkt.y < 0);
            Console.WriteLine($"Pierwsza: {ilePierwsza}, druga: {ileDruga}, trzecia: {ileTrzecia}, czwarta: {ileCzwarta}");

            //które mają wartość dwucyfrową
            List<Punkt> dwucyfrowe = lista.FindAll(punkt => (punkt.x == 20 || punkt.x == -20) && (punkt.y == 20 || punkt.y == -20));
            dwucyfrowe.ForEach(punkt => Console.WriteLine(punkt));
            //Czy istnieje jakiś punkt o współrzędnej x równej -20 i dowolnej ujemnej współrzędnej y
            Console.WriteLine(lista.Any(punkt => punkt.x == -20 && punkt.y < 0));
            Console.WriteLine();

            //punkty na listę stringów tak aby każdy punkt był przechowywany w następującym formacie: "(x, y)"
            //List<string> punkty = lista.Select(punkt => punkt.x).ToList(); //punkt.y.ToString);


        }
    }
}
