using System;
using System.Collections.Generic;
using System.Text;

namespace DziedziczenieLekcja
{
    class KlientFirma : Klient // KlientFirma - klasa pochodna, Klient - klasa bazowa
    {
        private string nip;
        private bool vat;

        public KlientFirma(string imie, string nazwisko, string tel, int kwota, string nip, bool vat) : base(imie, nazwisko, tel, kwota)
        {
            this.nip = nip;
            this.vat = vat;
        }

        public string Nip { get => nip; set => nip = value; }
        public bool Vat { get => vat; set => vat = value; }
    }
}
