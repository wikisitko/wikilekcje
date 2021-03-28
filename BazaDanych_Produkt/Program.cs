using System;

namespace BazaDanych_Produkt
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Baza())
            {
                Produkt p1 = new Produkt
                {
                    Nazwa = "Jogurt",
                    Producent = "Bakoma",
                    Cena = 14.99
                };
                context.Produkty.Add(p1);
                context.SaveChanges();
            }
                
            using (var context = new Baza())
            {
                    foreach (var item in context.Produkty)
                    {
                        Console.WriteLine($"{item.Id} {item.Nazwa} {item.Producent} {item.Cena}");
                    }
            }
            Console.WriteLine("Koniec");            
        }
    }
}
