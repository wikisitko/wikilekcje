using System;
using System.Collections.Generic;
using System.Text;

namespace Samolot_Zadanie 
{
    public class Silnik : ICzujnik
    {
        protected int aktualnaMoc;
        protected int aktualnyCzasPracy;


        public Silnik(int aktualnaMoc, int aktualnyCzasPracy)
        {
            this.aktualnaMoc = aktualnaMoc;
            this.aktualnyCzasPracy = aktualnyCzasPracy;
        }

        public double temp()
        {
            return (aktualnaMoc / 10) * (aktualnyCzasPracy * 100);
        }

        public double dopuszczalnaTemp()
        {
            return 2000;
        }
        public bool Alarm()
        {
            if (dopuszczalnaTemp() < temp())
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Aktualna moc: {aktualnaMoc}, aktualny czas pracy {aktualnyCzasPracy}";
        }


    }
}
