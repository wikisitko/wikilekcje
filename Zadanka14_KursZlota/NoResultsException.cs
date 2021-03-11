using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka14_KursZlota
{
    class NoResultsException : Exception
    {
        public NoResultsException() : base ("Brak ")
        {

        }
    }
}
