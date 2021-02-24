using System;
using System.Collections.Generic;
using System.Text;

namespace Teksty_Zadanie
{
    //klasa abstrakcyjna - to taka klasa ktorej obiektu nie mozna stworzyc (czyli nie mozna napisac np new Tekst)
    //Tekst t = new Ksiazka(...) -- to mozna (zmienna Tekst)
    //Tekst t = new Tekst(..) -- tego nie mozna
    //slowo abstract informuje o klasie abstrakcyjnej
    public abstract class Tekst
    {
        protected int id;
        protected string tresc;

        private static int licznik;
         static Tekst()
        {
            licznik = 1;
        }

        public Tekst(string tresc)
        {
            this.id = licznik;
            this.tresc = tresc;
            licznik++;
        }

        //funkcja abstrakcyjna moze byc tylko w klasie abstrakcyjnej
        public abstract double ObliczWartosc();

        public abstract string TypTekstu();

        public override string ToString()
        {
            return $"ID: {id}, TREŚĆ: {tresc}";
        }
    }
}
