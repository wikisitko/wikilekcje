using System;
using System.Collections.Generic;
using System.Text;

namespace Twitch_Zadanie
{
    public class Paypal : Donate
    {
        private string numerKonta;
        public Paypal(int id, string nazwaUzytkownika, string tresc, double kwota, string data, string numerKonta) : base(id, nazwaUzytkownika, tresc, kwota, data)
        {
            this.numerKonta = numerKonta;
        }
        public override double KwotaNetto()
        {
            if (Tresc.Length > 100)
            {
                return Kwota - (0.25 * Kwota);
            }
            else
            {
                return Kwota - (0.05 * Kwota);
            }

        }
        public override string ToString()
        {
            return base.ToString() + $" {numerKonta}";
        }
    }
}
