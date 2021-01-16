using System;
using System.Collections.Generic;
using System.Text;

namespace DziedziczenieCwiczeniaLekcja
{
    class Prostokat : Figura
    {
        private int a;
        private int b;

        public Prostokat(int x, int y, int a, int b) : base(x, y)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return base.ToString() + $", a = {a}, b = {b}";
        }

        public override int Pole()
        {
            return a * b;
        }
    }
}
