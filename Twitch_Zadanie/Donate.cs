using System;
using System.Collections.Generic;
using System.Text;

namespace Twitch_Zadanie
{
    public class Donate
    {
        //(id, nazwa uzytkownika, treść donate, kwota, data przesłania) oraz pole statyczne licznik
        private int id;
        private string nazwaUzytkownika;
        private string tresc;
        private double kwota;
        private DateTime data;
        private static int licznik;

        public double Kwota { get => kwota; set => kwota = value; }
        public string Tresc { get => tresc; set => tresc = value; }

        static Donate()
        {
            licznik = 0;
        }

        public Donate(int id, string nazwaUzytkownika, string tresc, double kwota, string data)
        {
            this.id = licznik;
            this.nazwaUzytkownika = nazwaUzytkownika;
            this.Tresc = tresc;
            this.Kwota = kwota;
            this.data = DateTime.Parse(data);
            licznik++;
        }
        public virtual double KwotaNetto()
        {
            return Kwota;
        }
        public override string ToString()
        {
            return $"{id}, {nazwaUzytkownika}, {tresc}, {kwota}, {data.ToShortDateString()}, {licznik}";
    
        }
    }

        
    
}
