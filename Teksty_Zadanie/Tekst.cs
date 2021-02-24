using System;
using System.Collections.Generic;
using System.Text;

namespace Teksty_Zadanie
{
    public class Tekst
    {
        protected int id;
        protected string tresc;

        private static int licznik;
         static Tekst()
        {
            licznik = 1;
        }

        public Tekst()
        {

        }

        public Tekst(string tresc)
        {
            this.id = licznik;
            this.tresc = tresc;
            licznik++;
        }

        public virtual double ObliczWartosc() //virtual - "nadpisz mnie", funkcje z klas pochodnych moga nadpisywac (override) ta funkcje
        {
            return 0;
        }

        public override string ToString()
        {
            return $"ID: {id}, TREŚĆ: {tresc}";
        }
    }
}
