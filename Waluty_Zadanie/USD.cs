using System;
using System.Collections.Generic;
using System.Text;

namespace Waluty_Zadanie
{
    class USD : Waluta
    {
        public USD(double wartosc) : base(wartosc)
        {
        }

        public override double PrzeliczPLN()
        {
            return wartosc * 3.9;
        }

        public override string ToString()
        {
            return $"{wartosc}$";
        }
    }
}
