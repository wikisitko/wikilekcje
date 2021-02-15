using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka8
{
    public class Gracz
    {
        private string imie;
        private string nazwisko;
        private int punkty;

        public Gracz()
        {
        }

        public Gracz(string imie, string nazwisko, int punkty)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.punkty = punkty;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Punkty { get => punkty; set => punkty = value; }

        public override string ToString()
        {
            return $"Imie: {imie}, nazwisko: {nazwisko}, punkty: {punkty}";
        }
    }
}
