using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lekcja2
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime rokUrodzenia;
        private string miasto;

        public Osoba(string imie, string nazwisko, DateTime rokUrodzenia, string miasto)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.RokUrodzenia = rokUrodzenia;
            this.Miasto = miasto;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public DateTime RokUrodzenia { get => rokUrodzenia; set => rokUrodzenia = value; }
        public string Miasto { get => miasto; set => miasto = value; }

        public override string ToString()
        {
            return $"{imie} {nazwisko} {rokUrodzenia} {miasto}";
        }
    }
}
