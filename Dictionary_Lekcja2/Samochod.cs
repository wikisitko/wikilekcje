using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_Lekcja2
{
    class Samochod
    {
        private string marka;
        private string model;
        private int rokProdukcji;

        public Samochod(string marka, string model, int rokProdukcji)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
        }

        public override string ToString()
        {
            return $"{marka} {model} {rokProdukcji}"; 
        }

        public int Wiek()
        {
            return DateTime.Now.Year - rokProdukcji;
        }
    }
}
