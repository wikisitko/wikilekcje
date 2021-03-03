using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    public enum rodzajPolaczenia { Wifi, Bluetooth, USB }
    public class UrzadzenieWielofunkcyjne : Urzadzenie, ISkanowanie, IDrukowanie
    {
        private rodzajPolaczenia rodzajPolaczenia;

        public UrzadzenieWielofunkcyjne(string model, string marka, rodzajPolaczenia rodzajPolaczenia) : base (model, marka)
        {
            this.rodzajPolaczenia = rodzajPolaczenia;
        }

        //public int IloscTuszu => 100; //jest bedzie proba pobrania wartosci ze IloscTuszu to za kazdym razem dostaniemy wartosc 100
        public int IloscTuszu { get => 100; }

        //public int iloscTuszu()
        //{
        //    return 100; //chwilowe rozwiazanie
        //}

        public string DrukujMetoda()
        {
            return $"Wielofunkcyjna: Drukowanie...";
        }

        public string Skanuj()
        {
            return $"Wielofunkcyjna: Skanowanie...";
        }
        public override string ToString()
        {
            return base.ToString() + $"Rodzaj polaczenia: {rodzajPolaczenia}";
        }
    }
}
