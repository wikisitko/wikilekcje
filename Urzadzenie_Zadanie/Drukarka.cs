﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    public class Drukarka : Urzadzenie, IDrukowanie
    {
        private int iloscTuszu;

        public int IloscTuszu { get => iloscTuszu; }

        public Drukarka(string model, string marka, int iloscTuszu) : base (model, marka)
        {

            if (iloscTuszu < 0)
            {
                throw new UjemnaWartoscException();
            }
            else
            {
                this.iloscTuszu = iloscTuszu;
            }
            //this.iloscTuszu = iloscTuszu; //jakby tutaj podac ilosc i zeby stad przekazywalo funkcji ponizej i potem sie liczylo

        }

        public string DrukujMetoda()
        {
            return $"Drukarka: Drukowanie...";
        }

        //public int iloscTuszu()
        //{
        //    return iloscTuszu;
        //}
        public override string ToString()
        {
            return base.ToString() + $" Ilosc tuszu: {iloscTuszu}";
        }

    }
}
