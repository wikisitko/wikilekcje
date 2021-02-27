using System;
using System.Collections.Generic;
using System.Text;

namespace Waluty_Zadanie
{
    public abstract class Waluta
    {
        protected double wartosc;

        protected Waluta(double wartosc)
        {
            if (wartosc < 0)
            {
                throw new ValueExcepion();
            }
            this.wartosc = wartosc;
        }

        public abstract double PrzeliczPLN();
        public abstract override string ToString();

        public static double Suma(List<Waluta> waluty)
        {
            double suma = 0;
            foreach (var item in waluty)
            {
                suma += item.PrzeliczPLN();
            }
            return suma;
        }
    }
}

