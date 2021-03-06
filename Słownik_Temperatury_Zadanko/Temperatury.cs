using System;
using System.Collections.Generic;
using System.Text;

namespace Słownik_Temperatury_Zadanko
{
    class Temperatury
    {
        private Dictionary<string, double> data;

        public Temperatury()
        {
            data = new Dictionary<string, double>();
        }

        public void Dodaj(string miasto, double temperatura)
        {
            data[miasto] = temperatura;
        }

        public List<string> TmpMniejNiz20()
        {
            //Temp wyższa niż 20 stopni:
            List<string> miasta = new List<string>();
            foreach (var item in data)
            {
                if (item.Value > 20)
                {
                    miasta.Add(item.Key);
                }
            }
            return miasta;
}
        public double SredniaTmp() {
            //Średnia temp
            double srednia = 0;
            foreach (var item in data)
            {
                srednia += item.Value;
            }
            return srednia / data.Count;
        }

        public void TmpNizszaNizPoznan()
        {
            //mniejsza temp niz Poznan
            Console.WriteLine("Temperatura niższa niż Poznań: ");
            foreach (var item in data)
            {
                if (item.Value < data["Poznań"])
                {
                    Console.WriteLine($" {item.Key}");
                }
            }
        }

        public double MaxTmp()
        {
            //temp max
            double max = 0;
            foreach (var item in data)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                }
            }
            return max;
        }

        public void MinTmp()
        {
            //min
            Console.WriteLine("Najniższa temperatura: ");
            double min = double.MaxValue;
            string miasto = "";
            foreach (var item in data)
            {
                if (item.Value < min)
                {
                    min = item.Value;
                    miasto = item.Key;
                }
            }
            Console.WriteLine(miasto);
        }

        public void Sortowanie()
        {
            //sortowanie
            List<double> values = new List<double>();
            foreach (var item in data.Values)
            {
                values.Add(item);
            }
            values.Sort();
            values.Reverse();
            foreach (var item in values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
