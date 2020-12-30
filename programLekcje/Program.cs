using System;
using System.IO;

namespace programLekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateText = File.ReadAllText(@"C:\Users\Wiktoria Sitko\Documents\GitHub\wikilekcje\programLekcje\lekcje.txt");
            Console.WriteLine(dateText);


        }
    }
}
