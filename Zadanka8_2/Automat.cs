using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka8_2
{
    class Automat
    {
        private List<Moneta> monety;

        public Automat()
        {
        }
        
        public Automat(List<Moneta> monety)
        {
            this.monety = monety;
            Monety = new List<Moneta>();
        }

        public List<Moneta> Monety { get => monety; set => monety = value; }

       

        public void Wrzuc(Moneta moneta)
        {
            Monety.Add(moneta);
        }

        public void ZamowKawe(string wielkosc)
        {
            if (monety.Count >= 2 && wielkosc == "mala")
            {
                Console.WriteLine("Mała kawa kupiona");
            }
            else if (monety.Count >= 3 && wielkosc == "duza")
            {
                Console.WriteLine("Duża kawa kupiona");
            }
            else
            {
                Console.WriteLine("Niewystarczająca ilość monet");
            }


            monety.Clear();
        }

        public override string ToString()
        {
            return $"Zamowiono x kaw";
        }
    }
}
