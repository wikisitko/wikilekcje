using System;
using System.Collections.Generic;
using System.Text;

namespace Waluty_Zadanie
{
    public class PLN : Waluta
    {
        public PLN(double wartosc) : base(wartosc)
        {
        }

        public override double PrzeliczPLN()
        {
            return wartosc;
        }

        public override string ToString()
        {
            return $"{wartosc}ZŁ";
        }
    }
}
