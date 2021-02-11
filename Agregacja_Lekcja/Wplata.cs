using System;
using System.Collections.Generic;
using System.Text;

namespace Agregacja_Lekcja
{
    public class Wplata
    {
        private int zl;
        private int gr;

        public Wplata()
        {

        }
        public Wplata(int zl, int gr)
        {
            this.zl = zl + gr/100;
            this.gr = gr % 100;
        }

        public int Zl { get => zl; set => zl = value; }
        public int Gr { get => gr; set => gr = value; }

        public override string ToString()
        {
            return $"{Zl}zł {Gr}gr";
        }

        public int AllGrosze()
        {
            return zl * 100 + gr;
        }
    }
}
