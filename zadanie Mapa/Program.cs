using System;

namespace zadanie_Mapa
{
    class Program
    {
        static void Main(string[] args)
        {
            Class c1 = new Class();
            c1.Add("Ania", "Kowalska", 2000, 5);
            c1.Add("Adam", "Kowalski", 2001, 2);

            Console.WriteLine(c1);

            Console.ReadLine();
        }
    }
}
