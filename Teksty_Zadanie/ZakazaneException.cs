﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Teksty_Zadanie
{
    public class ZakazaneException : Exception
    {
        public ZakazaneException() : base("Ta nazwa jest zakazana")
        { 
        
        }
    }
}
