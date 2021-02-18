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
        private string numerPolisy;
        private List<Polisa> polisy;
        private string imie;
        private string nazwisko;
        private string dataUrodzenia;
        private string telefon;

        //sprawdzic ktore potrzebne!!!
        public static int LicznikPolis { get => licznikPolis; set => licznikPolis = value; }
        public double Wartosc { get => wartosc; set => wartosc = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string NumerPolisy { get => numerPolisy; set => numerPolisy = value; }
        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        private enum WariantPolisy { podstawowa, srebrna, złota, platynowa, premium, supreme }


        static Polisa()
        {
            LicznikPolis = 100;
        }

        public Polisa(double wartosc, string nazwa, string numerPolisy, string imie, string nazwisko, string dataUrodzenia, string telefon)
        {
            this.wartosc = wartosc;
            this.nazwa = nazwa;
            this.numerPolisy = numerPolisy;
            this.polisy = new List<Polisa>();
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia; //DateTime.Parse(dataUrodzenia); idk czemu nie dziala :(
            this.telefon = telefon;
        }

        //nazwa musi zawierac wariant polisy, jak nie to wyjątek???
        public void DodajPolise(Polisa p)
        {
            polisy.Add(p);
        }
        //public double DodatkowaOplata(Polisa p)
        //{

        //    //if (dataUrodzenia.Year < 30) //jak naprawie datetime to bedzie dzialalo
        //    //{
        //    //    wartosc += (0.05 * wartosc);
        //    //}

        //    //return wartosc;
        //}


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"PLS {imie[0]}{nazwisko[0]}/{numerPolisy}: {imie} {nazwisko} tel.:{telefon}");

            return builder.ToString();
        }
    }
}
