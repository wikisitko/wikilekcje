using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    public interface ISkanowanie
    {
        string Skanuj()
        {
            return $"Skanowanie...";
        }
    }
}
