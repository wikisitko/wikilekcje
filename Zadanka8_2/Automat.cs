using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka8_2
{
    enum KawaWielkosc { Mala, Duza }
    class Automat
    {
        private List<Moneta> monety;
        int licznik = 0;

        public Automat()
        {
            Monety = new List<Moneta>();
        }
       

        public List<Moneta> Monety { get => monety; set => monety = value; }

       

        public void Wrzuc(Moneta moneta)
        {
            Monety.Add(moneta);
        }

        public void ZamowKawe(KawaWielkosc wielkoscKawy)
        {

            if (monety.Count >= 2 && wielkoscKawy == KawaWielkosc.Mala)
            {
                Console.WriteLine("Mała kawa kupiona");
                monety.Clear();
                licznik++;
            }
            else if (monety.Count >= 3 && wielkoscKawy == KawaWielkosc.Duza)
            {
                Console.WriteLine("Duża kawa kupiona");
                monety.Clear();
                licznik++;
            }
            else
            {
                Console.WriteLine("Niewystarczająca ilość monet");
            }


           
        }

        public override string ToString()
        {
            return $"Zamowiono {licznik} kaw_ę_y";
        }
    }
}
