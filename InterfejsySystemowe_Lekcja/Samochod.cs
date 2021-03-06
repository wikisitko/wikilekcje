using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfejsySystemowe_Lekcja
{
    //drugi sposob porownania dwoch obiektow klasy samochod
    class SamochodWiekComparer : IComparer<Samochod>
    {
        public int Compare(Samochod x, Samochod y)
        {
            return y.Wiek().CompareTo(x.Wiek());
        }
    }

    class Samochod : IComparable<Samochod>
    {
        private string marka;
        private string model;
        private int rokProdukcji;

        public Samochod(string marka, string model, int rokProdukcji)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
        }

        //domyslny sposob porownania dwoch obiektow klasy samochod
        //comapre to -> zwraca 0 jesli oba obiekty sa sobie rowne
        //1 jesli obiekt pierwszy jest wiekszy od drugiego
        //-1 jesli obiekty drugi jest wiekszy od pierwszego
        public int CompareTo(Samochod other)
        {
            if(model.CompareTo(other.model) == 0)
            {
                return marka.CompareTo(other.marka);
            }
            else
            {
                return model.CompareTo(other.model);
            }
        }

        public override string ToString()
        {
            return $"{marka} {model} {rokProdukcji}";
        }

        public int Wiek()
        {
            return DateTime.Now.Year - rokProdukcji;
        }
    }
}
