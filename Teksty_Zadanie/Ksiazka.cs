using System;
using System.Collections.Generic;
using System.Text;

namespace Teksty_Zadanie
{
    public class Ksiazka : Tekst
    {
        private string autor;
        private string tytul;


        public Ksiazka(string autor, string tytul, string tresc) : base(tresc) //how to wyjątki
        {
            if (autor == "Adolf Hitler" || tytul == "Mein Kampf")
            {
                throw new ZakazaneException();
            }

            else
            {
                this.autor = autor;
                this.tytul = tytul;
            }
            
        }

        public override double ObliczWartosc()
        {
            if (autor == "Stephen Prata" || autor == "Jerzy Grebosz")
            {
                return tresc.Length * 0.7;
            }
            else
            {
                return tresc.Length * 0.5;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"AUTOR: {autor}, TYTUŁ: {tytul}";
        }
    }
}
