using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    public class Skaner : Urzadzenie, ISkanowanie
    {
        private int szybkoscSkanowania;

        public Skaner(string model, string marka, int szybkoscSkanowania) : base(model, marka)
        {
            if (szybkoscSkanowania < 0)
            {
                throw new UjemnaWartoscException();
            }
            else
            {
                this.szybkoscSkanowania = szybkoscSkanowania;
            }
            
        }
        public string Skanuj()
        {
            return $"Skaner: Skanowanie...";
        }
        public override string ToString()
        {
            return base.ToString() + $"Szybkosc skanowania: {szybkoscSkanowania}";
        }
    }
}
