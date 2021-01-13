using System;
using System.Collections.Generic;
using System.Text;

namespace DziedziczenieLekcja
{
    class Klient
    {
        private string imie;
        private string nazwisko;
        private string tel;
        private int kwota;

        public Klient(string imie, string nazwisko, string tel, int kwota)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.tel = tel;
            this.kwota = kwota;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Tel { get => tel; set => tel = value; }
        public int Kwota { get => kwota; set => kwota = value; }

        public override string ToString()
        {
            return $"{Imie} {nazwisko} {tel} {kwota}";
        }
    }
}
