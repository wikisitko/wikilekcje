using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    class BrakInfoException : Exception
    {
        public BrakInfoException() : base("Podaj poprawne informacje")
        {
        }
    }
}
