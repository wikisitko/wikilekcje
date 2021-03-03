using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    class BrakTuszuException : Exception
    {
        public BrakTuszuException() : base("Brakuje tuszu. Drukowanie niemożliwe.")
        {

        }
    }
}
