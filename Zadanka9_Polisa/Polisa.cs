using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka9_Polisa
{
    class Polisa
    {
        private static int licznikPolis;
        private double wartosc;
        private string nazwa;
        private string imie;
        private string nazwisko;
        DateTime dataUrodzenia;
        private string telefon;
        private string numerPolisy;

        //sprawdzic ktore potrzebne!!!
        public static int LicznikPolis { get => licznikPolis; set => licznikPolis = value; }
        public double Wartosc { get => wartosc; set => wartosc = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string NumerPolisy { get => numerPolisy; set => numerPolisy = value; }

        private enum WariantPolisy { podstawowa, srebrna, złota, platynowa, premium, supreme }


        static Polisa()
        {
            LicznikPolis = 100;
        }

        public Polisa(double wartosc, string nazwa, string wlasciciel, DateTime dataUrodzenia, string telefon, string numerPolisy, string imie, string nazwisko)
        {
            Wartosc = wartosc;
            Nazwa = nazwa;
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
            Telefon = telefon;
            NumerPolisy = numerPolisy;
            
        }

        public void DodatkowaOplata()
        {
            if (dataUrodzenia.Year < 30)
            {
                wartosc += (0.05 * wartosc);
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"PLS {imie[0]}{nazwisko[0]}/{numerPolisy}: ({WariantPolisy.platynowa})" );

            return builder.ToString();
        }
    }
}
