using System;
using System.Collections.Generic;
using System.Text;

namespace Teksty_Zadanie
{
    public enum Rodzaj { Stroficzny, Stychiczny, Bialy, Sylabiczny }
    public class Wiersz : Tekst
    {
        private Rodzaj rodzaj;
        public Wiersz(string tresc, Rodzaj rodzaj) : base(tresc)
        {
            this.rodzaj = rodzaj;
        }

        public override double ObliczWartosc()
        {
            if (rodzaj == Rodzaj.Sylabiczny)
            {
                return tresc.Length * 3;
            }

            else
            {
                return tresc.Length * 3.5;
            }
            
        }

        public override string ToString()
        {
            return base.ToString() + $"RODZAJ: {rodzaj}";
        }

        public override string TypTekstu()
        {
            return "Wiersz";
        }
    }
}
