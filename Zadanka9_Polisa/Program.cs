using System;
using System.Collections.Generic;

namespace Zadanka9_Polisa
{
    class Program
    {
        static void Main(string[] args)
        {
            Polisa p = new Polisa(50, "platynowa", "34565", "Jan", "Kowalski", "10/03/1981", "609876432");

            List<Polisa> pol = new List<Polisa>();
            pol.Add(p);



            

        }
    }
}
