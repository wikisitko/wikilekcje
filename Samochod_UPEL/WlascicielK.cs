using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod_UPEL
{
    public class WlascicielK
    {
        private string imie;
        private string nazwisko;
        private string telefon;
        private bool polisa;

        public WlascicielK(string imie, string nazwisko, string telefon, bool polisa)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            if (telefon.Length == 9)
            {
                this.telefon = telefon;
            }
            else
            {
                throw new PhoneNumberException();
            }
            this.Polisa = polisa;
        }

        public bool Polisa { get => polisa; set => polisa = value; }

        public override string ToString()
        {
            return $"{imie} {nazwisko} ({telefon})";
        }
    }
}
