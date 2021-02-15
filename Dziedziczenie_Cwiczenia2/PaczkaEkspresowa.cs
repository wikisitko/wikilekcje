using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Cwiczenia2
{
    public class PaczkaEkspresowa : Paczka
    {
        private DateTime dataDoreczenia;

        public DateTime DataDoreczenia { get => dataDoreczenia; set => dataDoreczenia = value; }

        public PaczkaEkspresowa() : base()
        {

        }

        public PaczkaEkspresowa(double waga, string nadawca, string data) : base(waga, nadawca)
        {
            dataDoreczenia = DateTime.Parse(data);
        }

        public PaczkaEkspresowa(double waga, string nadawca) : base(waga, nadawca)
        {
            dataDoreczenia = DateTime.Now.AddDays(1);
        }

        public override double ObliczCene()
        {
            return base.ObliczCene() + 10;
        }

        public override string ToString()
        {
            return $"(Paczka ekspresowa) {Nadawca} {Waga}kg {ObliczCene()}zł data doręczenia: {dataDoreczenia.ToShortDateString()}";
        }
    }
}
