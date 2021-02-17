using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Cwiczenia3
{
    class Uczen : Osoba
    {
        private double ocena;
        private string zachowanie;

        public Uczen(string imie, string nazwisko, string dataUrodzenia, string pesel, Plec plec, double ocena, string zachowanie) : base(imie, nazwisko, dataUrodzenia, pesel, plec) //base - wywyluje konstruktor z klasy bazowej
        {
            this.Ocena = ocena;
            this.Zachowanie = zachowanie;
        }

        public double Ocena { get => ocena; set => ocena = value; }
        public string Zachowanie { get => zachowanie; set => zachowanie = value; }

        public override string ToString()
        {
            //base.ToString(); - wywlowanie ToString z klasy Osoba
            return base.ToString() + $" ocena: {ocena} zachowanie: {zachowanie}";
        }

        public override double ObliczUbezpieczenie()
        {
            return (6 - ocena) * 10;
        }
    }
}
