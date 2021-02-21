using System;
using System.Collections.Generic;
using System.Text;

namespace Wyjatki_Lekcja
{
    class ZlyPrzedzialException : Exception
    {
        public ZlyPrzedzialException() : base("Podano zly przedzial, poczatek musi byc mniejszy od konca przedzialu")
        {

        }
    }
}
