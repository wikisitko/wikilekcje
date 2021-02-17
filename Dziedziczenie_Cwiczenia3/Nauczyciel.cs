using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Cwiczenia3
{
    class Nauczyciel : Osoba
    {
        private string specjalizacja;
        private DateTime dataZatrudnienia;

        public Nauczyciel(string imie, string nazwisko, string dataUrodzenia, string pesel, Plec plec, string specjalizacja, string dataZatrudnienia) : base(imie, nazwisko, dataUrodzenia, pesel, plec)
        {
            this.Specjalizacja = specjalizacja;
            this.DataZatrudnienia = DateTime.Parse(dataZatrudnienia);
        }

        public string Specjalizacja { get => specjalizacja; set => specjalizacja = value; }
        public DateTime DataZatrudnienia { get => dataZatrudnienia; set => dataZatrudnienia = value; }

        public override string ToString()
        {
            //base.ToString(); - wywlowanie ToString z klasy Osoba
            return base.ToString() + $" specjalizacja: {specjalizacja} data zatrudnienia {dataZatrudnienia}";
        }

        public override double ObliczUbezpieczenie()
        {
            int lata = DateTime.Now.Year - dataZatrudnienia.Year;
            if(lata < 1)
            {
                return 50;
            }
            else if(lata < 10)
            {
                return 35;
            }
            else
            {
                return 10;
            }
        }
    }
}
