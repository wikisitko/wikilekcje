using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Plyta_Glowna
{
    class PlytaGlowna
    {
        public int licznik = 0;
        private string producent;
        private int maxRam;
        private List<Ram> pamiecRam;

        public PlytaGlowna(string producent, int maxRam)
        {
            this.producent = producent;
            this.maxRam = maxRam;
            this.pamiecRam = new List<Ram>();
        }

        public PlytaGlowna()
        {            
        }

        
        public int IloscRam() //naprawić 
        {
            
            foreach (var ram in pamiecRam)
            {
                licznik += ram.Pojemnosc;
            }

            return licznik;
        }
        public void Dodaj(Ram r) //zabezpieczyć 
        {
            pamiecRam.Add(r);
        }

        public void ZapisXML(string nazwaPliku)
        {
            XmlSerializer xml = new XmlSerializer(typeof(PlytaGlowna));
            StreamWriter writer = new StreamWriter(nazwaPliku);
            xml.Serialize(writer, this);
            writer.Close();
        }

        public static PlytaGlowna OdczytXML(string nazwaPliku)
        {
            XmlSerializer xml = new XmlSerializer(typeof(PlytaGlowna));
            StreamReader reader = new StreamReader(nazwaPliku);
            PlytaGlowna x = xml.Deserialize(reader) as PlytaGlowna;
            reader.Close();
            return x;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{producent}, {maxRam}, {licznik}");
            //builder.AppendLine($"");
            foreach (var ram in pamiecRam)
            {
                builder.AppendLine(ram.ToString());
            }
            return builder.ToString();
        }
    }
}
