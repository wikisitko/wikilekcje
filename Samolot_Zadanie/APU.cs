using System;
using System.Collections.Generic;
using System.Text;

namespace Samolot_Zadanie
{
    public class APU : ICzujnik
    {
        protected bool czyWlaczony;

        public APU(bool czyWlaczony)
        {
            this.czyWlaczony = czyWlaczony;
        }
        public double temp()
        {
            Random rand = new Random();

            if (czyWlaczony == true)
            {
                return rand.Next(0, 90);               
            }
            else
            {
                return 0;
            }
        }
        public double dopuszczalnaTemp()
        {
            return 80;
        }
       
        public override string ToString()
        {
            return $"";
        }
    }
}
