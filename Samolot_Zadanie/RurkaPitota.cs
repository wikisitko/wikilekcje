using System;
using System.Collections.Generic;
using System.Text;

namespace Samolot_Zadanie
{
    public class RurkaPitota : ICzujnik
    {
        protected DateTime dataProdukcji;
        protected int ilosc;

        public RurkaPitota(string dataProdukcji, int ilosc)
        {
            this.dataProdukcji = DateTime.Parse(dataProdukcji);
            this.ilosc = ilosc;
        }
        public double temp()
        {
            int liczba = 0;
            Random rand = new Random();

            if (DateTime.Now.Year - dataProdukcji.Year > 10)
            {
                for (int i = 0; i < ilosc; i++)
                {
                    liczba += rand.Next(0, 40);
                }
                return (liczba / ilosc);
            }
            else
            {
                for (int i = 0; i < ilosc; i++)
                {
                liczba += rand.Next(0, 30);
                }
                return (liczba/ilosc);

            }            
        }
        public double dopuszczalnaTemp()
        {
            return 25;
        }
       
        public override string ToString()
        {
            return $"Data produkcji: {dataProdukcji}, ilość: {ilosc}";
        }
    }
}
