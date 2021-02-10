using System;
using System.Collections.Generic;
using System.Text;

namespace SerializacjaLekcja
{
    [Serializable]
    public class Ocena
    {
        private double wartosc;
        private string temat;
        public Ocena() //domyslny potrzebny do serializacji XML
        {

        }
        public Ocena(double wartosc, string temat)
        {
            this.Wartosc = wartosc;
            this.Temat = temat;
        }

        public double Wartosc { get => wartosc; set => wartosc = value; }
        public string Temat { get => temat; set => temat = value; }
    }
}
