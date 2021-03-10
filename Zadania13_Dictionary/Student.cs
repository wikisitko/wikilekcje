using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania13_Dictionary
{
    public enum EgzaminTyp { PROE, PRM, ASiD }
    class Student
    {
        protected string imie;
        protected string nazwisko;
        private Dictionary<EgzaminTyp, int> wyniki;
        //private EgzaminTyp TypEgzaminu;

        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            wyniki = new Dictionary<EgzaminTyp, int>();
        }

        

        //public Dictionary<EgzaminTyp, int> Wyniki { get => wyniki; set => wyniki = value; }
        public void DodajWynik(EgzaminTyp Exam, int ocena)
        {
            wyniki.Add(Exam, ocena);
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Imie: {imie}, nazwisko: {nazwisko}");
            foreach (var item in wyniki)
            {
                builder.AppendLine($"{item.Key}: {item.Value}");
            }
            return builder.ToString();
        }


    }
}
