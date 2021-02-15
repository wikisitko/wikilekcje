using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Zadanka8
{
    public class Turniej
    {
        private string nazwa;
        private List<Gracz> gracze;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public List<Gracz> Gracze { get => gracze; set => gracze = value; }

        public Turniej()
        {
        }

        public Turniej(string nazwa)
        {
            this.Nazwa = nazwa;
            Gracze = new List<Gracz>();
        }

        public void Dodaj(Gracz gracz)
        {
            Gracze.Add(gracz);
        }

        public void ZapiszXML(string nazwaPliku)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Turniej));
            StreamWriter writer = new StreamWriter(nazwaPliku);
            xml.Serialize(writer, this);
            writer.Close();
        }

        public static Turniej WczytajXML(string nazwaPliku)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Turniej));
            StreamReader reader = new StreamReader(nazwaPliku);
            Turniej x = xml.Deserialize(reader) as Turniej;
            reader.Close();
            return x;
        }

        public Gracz MaxPunkty()
        {
            if(Gracze.Count == 0)
            {
                return null;
            }

            Gracz graczMax = Gracze[0];
            foreach (var gracz in Gracze)
            {
                if(gracz.Punkty > graczMax.Punkty)
                {
                    graczMax = gracz;
                }
            }
            return graczMax;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(nazwa);
            foreach (var gracz in gracze)
            {
                builder.AppendLine(gracz.ToString());
            }
            return builder.ToString();
        }
    }
}
