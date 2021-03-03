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
        //public int iloscTuszu()
        //{
        //    return 100; //chwilowe rozwiazanie
        //}
        public string Drukuj() //chcialabym zeby mi to tutaj pobieralo ilosc tuszu i jak zbyt malo to sie sypalo
        {           
               return $"Drukowanie...";         
        }

        public string Skanuj()
        {
            return $"Skanowanie...";
        }
        public override string ToString()
        {
            return base.ToString() + $"Rodzaj polaczenia: {rodzajPolaczenia}";
        }
    }
}
