using System;
using System.IO;

namespace programLekcje
{
    class Program
    {
           
        
        static void Main(string[] args)
        {
            string Path = @"C:\Users\Wiktoria Sitko\Documents\GitHub\wikilekcje\programLekcje\lekcje.csv";
            var lines = File.ReadAllLines(Path);
            string payment;


            for (int i = 1; i < lines.Length; i++)
            {
                var items = lines[i].Split(",");
                string date = items[0];
                payment = items[1];
                string name = items[2];
                int price = Int32.Parse(items[3]);

                //Console.WriteLine($"{date}  {payment}  {name}  {price}");
            }

            bool czyPing ()
            {
                if (payment == "ping")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
    }
}
