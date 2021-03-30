using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zadanka16_KartaPlatnicza
{
    class Transakcja
    {
        private List<Info> lista;

        public Transakcja()
        {
            var lines = File.ReadAllLines(@"..\..\..\dane.csv");

            foreach (var line in lines)
            {
                var values = line.Split(",");

                Info info = new Info(double.Parse(values[2]), values[10], values[13]);
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
        public void AlkoSuma() 
        {

        }
        public string Filtruj(string kategoria)
        {
            return "0";
        }
        public double MaxTransakcja()
        {
            return 0;
        }
    }
}
