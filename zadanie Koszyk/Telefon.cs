using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_Koszyk
{
    class Telefon
    {
        private string marka;
        private string model;
        private int cena;

        public Telefon(string marka1, string model1, int cena1)
        {
            this.marka = marka1;
            this.model = model1; 
            this.cena = cena1;
            
        }

        public int Cena { get => cena; }

        public override string ToString()
        {
            return $"Marka telefonu to {marka}, model to {model}, a cena to {Cena}";
        }
    }

}
