using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Dziedziczenie_Cwiczenia2
{
    [XmlInclude(typeof(PaczkaEkspresowa))]
    public class Klient
    {
        private string nazwa;
        private List<Paczka> paczki;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public List<Paczka> Paczki { get => paczki; set => paczki = value; }

        public Klient()
        {
            paczki = new List<Paczka>();
        }

        public Klient(string nazwa)
        {
            this.nazwa = nazwa;
            paczki = new List<Paczka>();
        }

        public void DodajPaczke(Paczka p)
        {
            paczki.Add(p);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(nazwa);
            foreach (var item in paczki)
            {
                builder.AppendLine(item.ToString());
            }
            return builder.ToString();
        }

        public double Zaplata()
        {
            return paczki.Sum(x => x.ObliczCene());
            //double suma = 0;
            //foreach (var item in paczki)
            //{
            //    suma += item.ObliczCene();
            //}
            //return suma;
        }

        public void ZapisXML(string nazwaPliku)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Klient));
            StreamWriter writer = new StreamWriter(nazwaPliku);
            xml.Serialize(writer, this);
            writer.Close();
        }

        //static - funkcji mozna uzywac nie tworzac obiektu typu Osoba
        public static Klient WczytajXML(string nazwaPliku)
        {
            //imie = "Radek"; //tego nie mozna tu uzyc bo nie pracujemy na konkretnym obiekcie klasy Osoba
            XmlSerializer xml = new XmlSerializer(typeof(Klient));
            StreamReader reader = new StreamReader(nazwaPliku);
            Klient x = xml.Deserialize(reader) as Klient;
            reader.Close();
            return x;
        }
    }
}
