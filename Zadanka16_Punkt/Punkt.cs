using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka16_Punkt
{
    public class Punkt
    {
        public int x;
        public int y;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{x} {y}";
        }
    }
}
