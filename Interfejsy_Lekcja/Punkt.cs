using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Interfejsy_Lekcja
{
    //Punkt implementuje interfejs IZapis
    //Mozna miec jedno dziedziczenie z jakiejs klasy
    //Mozna implementowac na raz wiele interfejsow
    //class Klasa : KlasaBazowa, Interfejs1, Interfejs2, Interfejs3 {}
    public class Punkt : IZapis
    {
        private int x;
        private int y;

        public Punkt()
        {

        }

        public Punkt(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public void ZapiszCSV(string plik)
        {
            File.WriteAllText(plik, $"{x};{y}\n");
        }

        public void ZapiszXML(string plik)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Punkt));
            using(StreamWriter writer = new StreamWriter(plik))
            {
                xml.Serialize(writer, this);
            }
        }

        public double OdlegloscOdSrodka()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
