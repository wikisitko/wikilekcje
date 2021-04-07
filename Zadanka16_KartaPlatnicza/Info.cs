using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zadanka16_KartaPlatnicza
{
    class InfoComparer : IComparer<Info>
    {
        public int Compare([AllowNull] Info x, [AllowNull] Info y)
        {
            return y.DataValue.CompareTo(x.DataValue);
        }
    }
    class Info : IComparable<Info>
    {
        private double dataValue;
        private string category; //series_Title_2
        private string type; //liquor

        public Info(double dataValue, string category, string type)
        {
            this.dataValue = dataValue;
            this.category = category;
            this.type = type;
        }

        public double DataValue { get => dataValue; set => dataValue = value; }
        public string Category { get => category; set => category = value; }
        public string Type_ { get => type; set => type = value; }

        public int CompareTo([AllowNull] Info other)
        {
            return dataValue.CompareTo(other.dataValue);
        }

        public override string ToString()
        {
            return $"{dataValue} {category} {type}";
        }
    }
}
