using System;
using System.Collections.Generic;
using System.Text;

namespace Twitch_Zadanie
{
    public enum Typ { głosowy, tekstowy, graficzny }
    public class Tipo : Donate
    {
        private Typ typ;

        public Tipo(int id, string nazwaUzytkownika, string tresc, double kwota, string data, Typ typ) : base (id, nazwaUzytkownika, tresc, kwota, data)
        {
            this.Typ = typ;
        }

        internal Typ Typ { get => typ; set => typ = value; }
        public override double KwotaNetto()
        {
            if (typ == Typ.głosowy)
            {
                return Kwota - (0.35 * Kwota);
            }
            else
            {
                return Kwota - (0.3 * Kwota);
            }
            
        }
        public override string ToString()
        {
            return base.ToString() + $" {typ}";
        }
    }
}

