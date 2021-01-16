using System;
using System.Collections.Generic;
using System.Text;

namespace DziedziczenieCwiczeniaLekcja
{
    class Kolo : Figura
    {
        private int r;

        public Kolo(int x, int y, int r) : base(x, y)
        {
            this.r = r;
        }

        public override string ToString()
        {
            return base.ToString() + $", r = {r}";
        }

        public override int Pole() //override - napisuje funkcje z klasy bazowej Figura 
        {
            return 3 * r * r;
        }
    }
}
