using System;

namespace BazyDanych_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            //KROK 7 pisanie kodu (zapis do bazy/odczyt) - KONIEC
            //zapis do bazy
            using (var context = new Baza()) //otwiera polaczenie z baza danych okreslona parametrem w tej w klasie
            {
                //sposob 1
                //Osoba os = new Osoba();
                //os.Imie = "Adam";
                //os.Nazwisko = "Kowalski";

                //sposob 2
                Osoba os = new Osoba
                {
                    Imie = "Adam",
                    Nazwisko = "Kowalski"
                };
                //jak dodac do bazy
                context.Osoby.Add(os); //dodaj nowa osobe do bazy
                context.SaveChanges(); //zapisz zmiany w bazie
            }

            //odczyt informacji z bazy
            using (var context = new Baza())
            {
                foreach (var item in context.Osoby)
                {
                    Console.WriteLine($"{item.Id} {item.Imie} {item.Nazwisko}");
                }
            }

            Console.WriteLine("Koniec");
        }
    }
}
