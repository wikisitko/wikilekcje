using System;
using System.Collections.Generic;

namespace Dictionary_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slownik - to zbior par klucz-wartosc, dla kazdego klucza odpowiada jakas wartosc
            Dictionary<string, int> dict = new Dictionary<string, int>();

            //jak cos dodac do slownika
            dict["Ada"] = 5; //pod klucz ada wpisuje wartosc 5

            //jak pobrac wartosc ze slownika
            Console.WriteLine(dict["Ada"]);

            //elementy slownika nie sa indeksowane tak w liscie!!!!!!
            //Console.WriteLine(dict[0]);

            Dictionary<string, int> oceny = new Dictionary<string, int>() //tworzy sie slownik z 3 parami klucz-wartosc
            {
                {"Ada", 5 },
                {"Ola", 4 },
                {"Ala", 4 }
            };

            //jak iterowc po slowniku
            foreach (var item in oceny)
            {
                Console.WriteLine($"{item.Key} ocena: {item.Value}");
            }
        }
    }
}
