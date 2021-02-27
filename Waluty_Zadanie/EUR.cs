using System;
using System.Collections.Generic;
using System.Text;

namespace Waluty_Zadanie
{
    public class EUR : Waluta
    {
        public EUR(double wartosc) : base(wartosc)
        {
        }

        public override double PrzeliczPLN()
        {
            return wartosc * 4.4;
        }

        public override string ToString()
        {
            return $"{wartosc}EURO";
        }
    }
}
