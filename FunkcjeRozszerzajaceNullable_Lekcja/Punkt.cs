using System;
using System.Collections.Generic;
using System.Text;

namespace FunkcjeRozszerzajaceNullable_Lekcja
{
    struct Punkt
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

        public void Zeruj()
        {
            x = 0;
            y = 0;
        }
    }
}
