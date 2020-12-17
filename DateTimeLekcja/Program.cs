using System;
using System.Globalization;
using System.IO;

namespace DateTimeLekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.ToString("yyyy-MM-dd"));
            Console.WriteLine(d1.Year);
            Console.WriteLine(d1.Month);
            Console.WriteLine(d1.Day);

            DateTime d2 = new DateTime(2000, 4, 17);
            int roznica = d1.Year - d2.Year;

            Console.WriteLine(roznica);

            DateTime d3 = new DateTime(1995, 5, 15);
            if(d2 > d3)
            {
                Console.WriteLine("OK");
            }

            DateTime fromDate = new DateTime(2020, 12, 1);
            DateTime toDate = new DateTime(2020, 12, 7);

            DateTime lessonDate = new DateTime(2020, 12, 2);

            if (lessonDate > fromDate && lessonDate < toDate)
            {
                Console.WriteLine("opis");
            }


            string date1 = "17/12/2020";
            string date2 = "2019/15/12";

            DateTime dateTime1;
            DateTime.TryParse(date1, out dateTime1); 
            DateTime dateTime2;
            DateTime.TryParseExact(date2, new string[] { "yyyy/dd/MM", "dd/MM/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime2);


            Console.WriteLine(dateTime1);
            Console.WriteLine(dateTime2);

            Console.WriteLine(dateTime1.Month);


            //Console.WriteLine("Podaj liczbe z przecinkiem?");
            //double x = double.Parse(Console.ReadLine());
            //Console.WriteLine(x);



            string dateText = File.ReadAllText(@"C:\Users\Wiktoria Sitko\Desktop\dane.txt");
            Console.WriteLine(dateText);

            DateTime dateTime3;
            DateTime.TryParse(dateText, out dateTime3);
            Console.WriteLine(dateTime3);

            //W pliku excel mozna dodawc odbyte lekcje
            //Kazda lekcja zawiera nastepujacy opis: data lekcji, data zaplaty, kto, cena
            //np
            //17-12-2020, 17-12-2020, Ada, 80
            //15-12-2020, ping, Kim, 80 (slowo ping oznacza ze dana osoba nie zaplacila za lekcje ktora juz sie odbyla"
            //Potrzebuje programu w ktorym moge dodawac nowe lekcje i wyswietlac liste osob ktore nie zaplacily za lekcje
        }
    }
}
