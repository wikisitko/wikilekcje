using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Agregacja_Lekcja
{
    public class Bankomat
    {
        private string lokalizacja;
        private List<Wplata> wplaty;
        public Bankomat()
        {

        }
        public Bankomat(string lokalizacja)
        {
            this.Lokalizacja = lokalizacja;
            Wplaty = new List<Wplata>();
        }

        public string Lokalizacja { get => lokalizacja; set => lokalizacja = value; }
        public List<Wplata> Wplaty { get => wplaty; set => wplaty = value; }

        //sposob v1
        //public override string ToString()
        //{
        //    string text = $"Bankomat: {lokalizacja}\n";
        //    foreach (var item in wplaty)
        //    {
        //        text += item + "\n";
        //    }
        //    return text;
        //}

        //sposob v2
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Bankomat: {lokalizacja}");
            foreach (var item in wplaty)
            {
                builder.AppendLine(item + "");
            }
            return builder.ToString();
        }

        public void Wplac(Wplata w)
        {
            wplaty.Add(w);
        }

        public Wplata MaxWplata()
        {
            if(wplaty.Count == 0)
            {
                return null;
            }
            else
            {
                Wplata max = wplaty[0];
                foreach (var item in wplaty)
                {
                    if(item.AllGrosze() > max.AllGrosze())
                    {
                        max = item;
                    }
                }
                return max;
            }
        }

        public int AllGrosze()
        {
            int grosze = 0;
            foreach (var item in wplaty)
            {
                grosze += item.AllGrosze();
            }
            return grosze;
        }

        public void ZapisXML(string nazwaPliku)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Bankomat));
            StreamWriter writer = new StreamWriter(nazwaPliku);
            xml.Serialize(writer, this);
            writer.Close();
        }

        //static - funkcji mozna uzywac nie tworzac obiektu typu Osoba
        public static Bankomat WczytajXML(string nazwaPliku)
        {
            //imie = "Radek"; //tego nie mozna tu uzyc bo nie pracujemy na konkretnym obiekcie klasy Osoba
            XmlSerializer xml = new XmlSerializer(typeof(Bankomat));
            StreamReader reader = new StreamReader(nazwaPliku);
            Bankomat x = xml.Deserialize(reader) as Bankomat;
            reader.Close();
            return x;
        }
    }
}
