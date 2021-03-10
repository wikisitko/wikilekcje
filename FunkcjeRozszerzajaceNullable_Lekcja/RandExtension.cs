using System;
using System.Collections.Generic;
using System.Text;

namespace FunkcjeRozszerzajaceNullable_Lekcja
{
    //nie mozna stworzyc obiektu tej klasy ani dziedziczyc ale mozna w nia wsadzic zmienne i metody statyczne
    static class RandExtension
    {
        //metoda rozszerzajaca musi byc w klasie poprzedzonej slowem static
        //metoda rozszerzajaca, poniewaz dodalem slowo this przed pierwszym argumentem
        //ten this oznacza ktory klase dokladnie rozszerza ta metoda
        public static List<int> Losuj(this Random rand, int ileLiczb)
        {
            List<int> liczby = new List<int>();
            for (int i = 0; i < ileLiczb; i++)
            {
                liczby.Add(rand.Next(0, 21));
            }
            return liczby;
        }
    }
}
