using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    class UjemnaWartoscException : Exception
    {
        public UjemnaWartoscException() : base ("Nie moze byc podana ujemna wartosc")
        {

        }
    }
}
