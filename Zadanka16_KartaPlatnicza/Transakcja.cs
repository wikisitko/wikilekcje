using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections;
using System.Globalization;

namespace Zadanka16_KartaPlatnicza
{
    class Transakcja
    {
        private List<Info> listaTypow = new List<Info>();

        public Transakcja(string path)
        {
            var lines = File.ReadAllLines(path);

            foreach (var line in lines.Skip(1)) //Skip odrzuca jeden element poczatkowy z tablicy
            {
                var values = line.Split(",");

                Info info = new Info(double.Parse(values[2], CultureInfo.InvariantCulture), values[10], values[13]);

                listaTypow.Add(info);

            }

            ////filename: @"..\..\..\dane.csv"
            //var lines = File.ReadAllLines(filename);

            //foreach (var line in filename)
            //{
            //    var values = line.Split(",");

            //    Info info = new Info(double.Parse(values[2]), values[10], values[13]);
            //}
        }

        //METODY DO ZROBIENIA
        public double AlkoSuma() 
        {
            //double suma = 0;

            //foreach (var item in listaTypow)
            //{
            //    if(item.Category == "Liquor")
            //    {
            //        suma += item.DataValue;
            //    }
            //}
            //return suma;
            return listaTypow.FindAll(x => x.Category == "Liquor").Sum(x => x.DataValue);
        }
        public List<Info> Filtruj(string kategoria)
        {
            return listaTypow.FindAll(x => x.Category == kategoria);
        }
        public Info MaxTransakcja()
        {
            //Info max = listaTypow[0];
            //for (int i = 1; i < listaTypow.Count; i++)
            //{
            //    if(listaTypow[i].DataValue > max.DataValue)
            //    {
            //        max = listaTypow[i];
            //    }
            //}
            //return max;
            //listaTypow.Sort(new InfoComparer());
            //return listaTypow[0];

            return listaTypow.Max();
        }
    }
}
