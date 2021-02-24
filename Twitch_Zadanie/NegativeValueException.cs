using System;
using System.Collections.Generic;
using System.Text;

namespace Twitch_Zadanie
{
    class NegativeValueException : Exception
    {
        public NegativeValueException() : base("Ujemna wartość")
        {

        }
    }
}
