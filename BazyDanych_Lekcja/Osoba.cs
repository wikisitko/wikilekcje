using System;
using System.Collections.Generic;
using System.Text;

namespace BazyDanych_Lekcja
{
    //KROK 1 pomysl na tabele
    class Osoba //to jest klasa-model reprezentujaca tabele danych, nie piszemy tutaj metod
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }
}
