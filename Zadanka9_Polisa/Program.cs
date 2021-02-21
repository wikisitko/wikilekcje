using System;
using System.Collections.Generic;

namespace Zadanka9_Polisa
{
    class Program
    {
        static void Main(string[] args)
        {
            Polisa p = new Polisa(50, "platynowa50", "Ola", "Kowalska", "15/04/2015", "458412589", WariantPolisy.platynowa);
            Console.WriteLine(p);

            Polisa p2 = new Polisa(70, "srebrna_X", "Ala", "Nowak", "10/06/1995", "254159658", WariantPolisy.srebrna);
            Console.WriteLine(p2);




        }
    }
}
