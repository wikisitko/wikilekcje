using System;
using System.Collections.Generic;
using System.Text;

namespace Plyta_Glowna
{
    public class Ram
    {
        private string nazwa;
        private int pojemnosc;

        public Ram()
        {

        }
        public Ram(string nazwa, int pojemnosc)
        {
            this.Nazwa = nazwa;
            this.Pojemnosc = pojemnosc;
        }

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int Pojemnosc { get => pojemnosc; set => pojemnosc = value; }

        public override string ToString()
        {
            
            return $"Nazwa: {nazwa}, {pojemnosc}GB";
        }
    }
}
