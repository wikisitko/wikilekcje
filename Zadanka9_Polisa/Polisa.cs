using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka9_Polisa
{
    public enum WariantPolisy { podstawowa, srebrna, złota, platynowa, premium, supreme }
    class Polisa
    {
        private static int licznikPolis; //zmienna statyczna jest jedna na caly program, nie zalezy od zadnego utworzonego obiektu klasy Polisa
        private double wartosc;
        private string nazwa;
        private string numerPolisy;
        private string wlasciciel;
        private DateTime dataUrodzenia;
        private string telefon;
        private WariantPolisy wariant;

        static Polisa()
        {
            licznikPolis = 100;
        }

        public Polisa(double wartosc, string nazwa, string imie, string nazwisko, string dataUrodzenia, string telefon, WariantPolisy wariant)
        {
            this.wariant = wariant;
            this.wartosc = wartosc;
            if(!nazwa.Contains(wariant.ToString()))
            {
                throw new Exception("Niepoprawna nazwa polisy");
            }
            this.nazwa = nazwa;
            this.wlasciciel = imie + " " + nazwisko;
            this.dataUrodzenia = DateTime.Parse(dataUrodzenia); 
            this.telefon = telefon;
            this.numerPolisy = $"PLS{imie[0]}{nazwisko[0]}\\" + licznikPolis.ToString().PadLeft(4, '0');
            //(string).PadLeft(4, '0') - jesli napis jest krotszy niz ilosc znakow okreslonych w argumencie 1 to wypelnia reszte miejsca zerami z lewej strony
            licznikPolis++; 
        }

        //nazwa musi zawierac wariant polisy, jak nie to wyjątek???

        public double DodatkowaOplata()
        {

            if (DateTime.Now.Year - dataUrodzenia.Year < 30) //jak naprawie datetime to bedzie dzialalo
            {
                wartosc += (0.05 * wartosc);
            }

            return wartosc;
        }


        public override string ToString()
        {
            return $"{numerPolisy} {nazwa} {dataUrodzenia.ToShortDateString()}";
        }
    }
}
