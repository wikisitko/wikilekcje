using System;
using System.Collections.Generic;
using System.Linq;

namespace WikiZadaniaLINQ
{
    public class Program
    {
        //Zapoznaj sie z klasami dolaczonymi do zadania (sklep, produkt) przestawiaja one tabele wystepujace w pewnej bazie danych
        //wykonaj ponizsze polecenia ale nie zmieniaj naglowkow funkcji oraz definicji innych klas i testow wystepujacych w programie
        //PS. Sklep celowo nie ma pola z lista produktow :)

        //testy: Test -> Run All Tests

        //napisz funkcje, ktora dla podanych argumentow zwraca liste produktow wystepujacych w danym sklepie
        //jesli argumenty sa niepoprawne to program powinien zwrocic null
        public static List<Produkt> ProduktySklep(List<Produkt> allProdukty, Sklep sklep)
        {
            //tutaj kod
            throw new NotImplementedException(); //to usunac
        }

        //napisz funkcje ktora zwraca produkt o podanym Id z listy produktow
        public static Produkt GetProdukt(List<Produkt> allProdukty, int id)
        {
            //tutaj kod
            throw new NotImplementedException(); //to usunac
        }

        //napisz funkcje, ktora zwraca kolekcje samych nazw produktow (IEnumerable<string>) dla danej kategorii
        public static IEnumerable<string> ProduktyZKategorii(List<Produkt> allProdukty, Kategoria kategoria)
        {
            //tutaj kod
            throw new NotImplementedException(); //to usunac
        }

        public static void Main(string[] args)
        {

        }
    }
}
