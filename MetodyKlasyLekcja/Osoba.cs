using System;
using System.Collections.Generic;
using System.Text;

namespace MetodyKlasyLekcja
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private int ocena;

        public Osoba(string imie, string nazwisko, int ocena)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.ocena = ocena;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Ocena { get => ocena; set => ocena = value; }

        public override string ToString()
        {
            return $"{imie} {nazwisko} {ocena}";
        }

        public string ToCsv()
        {
            return $"{Imie};{Nazwisko};{Ocena}\n";
        }
    }
}
