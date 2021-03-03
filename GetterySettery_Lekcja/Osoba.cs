using System;
using System.Collections.Generic;
using System.Text;

namespace GetterySettery_Lekcja
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private int licznikPobran;
        private Random random;

        public Osoba()
        {
            random = new Random();
        }

        public string Imie { 
            get
            {
                licznikPobran++;
                return imie;
            }
            set
            { 
                if(value.Length == 0)
                {
                    throw new Exception();
                }
                imie = value;
                Console.WriteLine($"Imie zostalo ustawione: {imie}");
            } 
        }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }

        public string Nazwa { get => imie + " " + nazwisko; }

        public int Losowa { get => random.Next(0, 20);  }

        public override string ToString() => $"{imie} {nazwisko} {licznikPobran}";

        public void Powitanie() => Console.WriteLine("Witaj!");

        public string GetNazwisko() => nazwisko;
    }
}
