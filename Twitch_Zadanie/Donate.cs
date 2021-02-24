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

        public Donate(string nazwaUzytkownika, string tresc, double kwota, string data)
        {
            if (Kwota < 0)
            {
                throw new NegativeValueException();
            }
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

        public static double MaxKwota(List<Donate> donejty) //jak to zrobic zeby bylo poza main :(
        {
            double max = 0;
            foreach (var don in donejty)
            {
                if (don.Kwota > max)
                {
                    max = don.Kwota;
                }
            }
            return max;
        }
    }

        
    
}
