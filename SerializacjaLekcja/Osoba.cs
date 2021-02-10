using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace SerializacjaLekcja
{
    [Serializable] //Oznaczamy ze cala klasa nadaje sie do zapisu binarnego [Atrybut]
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private string telefon;
        private int stawka;
        private List<Ocena> oceny;

        public Osoba()
        {
            this.Oceny = new List<Ocena>();
        }

        public Osoba(string imie, string nazwisko, string telefon, int stawka)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Telefon = telefon;
            this.Stawka = stawka;
            this.Oceny = new List<Ocena>();
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public int Stawka { get => stawka; set => stawka = value; }
        public List<Ocena> Oceny { get => oceny; set => oceny = value; }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} {Telefon} {Stawka}";
        }

        public void ZapisXML(string nazwaPliku)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Osoba));
            StreamWriter writer = new StreamWriter(nazwaPliku);
            xml.Serialize(writer, this);
            writer.Close();
        }

        //static - funkcji mozna uzywac nie tworzac obiektu typu Osoba
        public static Osoba WczytajXML(string nazwaPliku)
        {
            //imie = "Radek"; //tego nie mozna tu uzyc bo nie pracujemy na konkretnym obiekcie klasy Osoba
            XmlSerializer xml = new XmlSerializer(typeof(Osoba));
            StreamReader reader = new StreamReader("zapis.xml");
            Osoba x = xml.Deserialize(reader) as Osoba;
            reader.Close();
            return x;
        }

        public void ZapisBin(string nazwaPliku)
        {
            BinaryFormatter bin = new BinaryFormatter();
            FileStream file = new FileStream(nazwaPliku, FileMode.Create);
            bin.Serialize(file, this);
            file.Close();
        }

        public static Osoba WczytajBin(string nazwaPliku)
        {
            BinaryFormatter bin = new BinaryFormatter();
            FileStream file = new FileStream(nazwaPliku, FileMode.Open);
            Osoba x = bin.Deserialize(file) as Osoba;
            file.Close();
            return x;
        }

        public void ZapisJSON(string nazwaPliku)
        {
            string json = JsonSerializer.Serialize(this, typeof(Osoba));
            File.WriteAllText(nazwaPliku, json);
        }
    }
}
