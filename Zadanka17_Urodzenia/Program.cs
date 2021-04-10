using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Zadanka17_Urodzenia
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"..\..\..\dane17.csv";
            var lines = File.ReadAllLines(filename);
            List<BirthInfo> lista = new List<BirthInfo>();
            
            foreach (var line in lines.Skip(1))
            {
                var value = line.Split(",");
                BirthInfo birthInfo = new BirthInfo(Int32.Parse(value[0]), value[1], Int32.Parse(value[2]));
                lista.Add(birthInfo);

                
            }

            lista.RemoveAll(x => x.MothersAge == "Total");

            //wyświetlić w których latach ilość urodzeń była większa niż 11000 w grupie wiekowej 35 - 39  
            lista.FindAll(x => x.Count > 11000 && x.MothersAge.StartsWith("35") && x.MothersAge.EndsWith("39")).ForEach(x => Console.WriteLine(x));
           
            //policzyć w ilu latach ilość urodzeń w grupie wiekowej poniżej 15 lat wyniosła więcej niż 25
            Console.WriteLine(lista.Count(x => x.MothersAge == "Under 15" && x.Count > 25));

            //Sprawdzić czy w latach 2005 do 2013 była jakakolwiek grupa wiekowa, której ilość urodzeń wynosiła mniej niż 20
            Console.WriteLine(lista.Any(x => x.Period > 2005 && x.Period < 2013 && x.Count < 20));

            //Podać grupę wiekową i rok gdzie wskaźnik urodzeń (Count) był najmniejszy i największy(zastosuj Sort + IComparer)
            Console.WriteLine(lista.Max());
            Console.WriteLine(lista.Min());
        }
    }
}
