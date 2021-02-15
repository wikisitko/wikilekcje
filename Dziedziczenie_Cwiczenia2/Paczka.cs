using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Cwiczenia2
{
    public class Paczka
    {
        private double waga;
        private string adresat;

        public double Waga { get => waga; set => waga = value; }
        public string Nadawca { get => adresat; set => adresat = value; }

        public Paczka()
        {

        }

        public Paczka(double waga, string nadawca)
        {
            this.waga = waga;
            this.adresat = nadawca;
        }

        public virtual double ObliczCene()
        {
            return waga * 3.5;
        }

        public override string ToString()
        {
            return $"(Paczka) {adresat} {waga}kg {ObliczCene()}zł"; 
        }
    }
}
