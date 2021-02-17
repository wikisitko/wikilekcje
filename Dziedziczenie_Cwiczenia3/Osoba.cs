using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Cwiczenia3
{
    enum Plec { Mezczyzna, Kobieta }
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;
        private string pesel;
        private Plec plec;

        public Osoba(string imie, string nazwisko, string dataUrodzenia, string pesel, Plec plec)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.DataUrodzenia = DateTime.Parse(dataUrodzenia); //zamienia string z data na typ DateTime
            this.Pesel = pesel;
            this.Plec = plec;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string Pesel { get => pesel; set => pesel = value; }
        internal Plec Plec { get => plec; set => plec = value; }

        public override string ToString()
        {
            return $"{imie} {nazwisko} {dataUrodzenia.ToShortDateString()} {pesel} {plec}"; //ToShortDateString - skrocona data (bez czasu)
        }

        public virtual double ObliczUbezpieczenie() //virtual - "nadpisz mnie", funkcje z klas pochodnych moga nadpisywac (override) ta funkcje
        {
            return 0; //0 - nie jest czescia szkoly
        }
    }
}
