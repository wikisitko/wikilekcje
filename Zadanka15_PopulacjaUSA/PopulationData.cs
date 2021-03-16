using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zadanka15_PopulacjaUSA
{
    class YearComparer : IComparer<PopulationData>
    {
        public int Compare(PopulationData x, PopulationData y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
    
    class PopulationData
    {
        private string year;
        private int population;

        public PopulationData()
        {
            
        }

        public string Year { get => year; set => year = value; }
        public int Population { get => population; set => population = value; }



        public override string ToString()
        {
            return $"Year: {year}, population: {population}";
        }
    }
}
