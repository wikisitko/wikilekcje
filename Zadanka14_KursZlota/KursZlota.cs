using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka14_KursZlota
{
    public class KursZlota
    {
        private DateTime _data;
        private double _cena;

        public DateTime Data { get => _data; set => _data = value; }
        public double Cena { get => _cena; set => _cena = value; }

        public override string ToString()
        {
            return $"{Data} {Cena}";
        }
    }
}
