using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    public class Urzadzenie
    {
        protected string marka;
        protected string model;

        public Urzadzenie(string marka, string model)
        {
            if (marka == "" || model == "")
            {
                throw new BrakInfoException();
            }
            else
            {
                this.marka = marka;
                this.model = model;
            }
            
        }

        public override string ToString()
        {
            return $"Marka: {marka}, model: {model}";
        }
    }
}
