using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod_UPEL
{
    public class PhoneNumberException : Exception
    {
        public PhoneNumberException() : base("Podano zly numer telefonu")
        {

        }
    }
}
