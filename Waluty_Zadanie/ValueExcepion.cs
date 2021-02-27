using System;
using System.Collections.Generic;
using System.Text;

namespace Waluty_Zadanie
{
    class ValueExcepion : Exception
    {
        public ValueExcepion() : base ("Wartość nie może być mniejsza od zera!")
        {
        }
        

    }
}
