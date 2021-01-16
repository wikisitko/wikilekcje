using System;
using System.Collections.Generic;
using System.Text;

namespace DziedziczenieCwiczeniaLekcja
{
    class Figura
    {
        private int x;
        private int y;

        public Figura(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() //tutaj przypadek specjalny (bedzie zawsze override)
        {
            return $"x = {x}, y = {y}";
        }

        public virtual int Pole() //poprzez virtual oznaczamy funkcje jako polimorficzna/wirtualna czyli taka ktora mozna nadpisac w klasach dziedziczacych (slowem override)
        {
            return 0;
        }
    }
}
