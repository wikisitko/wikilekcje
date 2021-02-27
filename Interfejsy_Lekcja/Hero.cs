using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Interfejsy_Lekcja
{
    public class Hero : IZapis
    {
        private string name;
        private int hp;
        public Hero()
        {

        }
        public Hero(string name)
        {
            this.Name = name;
            Hp = 100;
        }

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }

        public override string ToString()
        {
            return $"name: {Name}, hp: {Hp}";
        }

        public void ZapiszCSV(string plik)
        {
            File.WriteAllText(plik, $"{name};{hp}\n");
        }

        public void ZapiszXML(string plik)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Hero));
            using (StreamWriter writer = new StreamWriter(plik))
            {
                xml.Serialize(writer, this);
            }
        }

        public void Walcz()
        {
            hp -= new Random().Next(0, 5);
        }
    }
}
