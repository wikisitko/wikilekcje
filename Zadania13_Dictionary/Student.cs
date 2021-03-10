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
        //private EgzaminTyp TypEgzaminu;

        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        Dictionary<EgzaminTyp, int> wyniki = new Dictionary<EgzaminTyp, int>();

        //public Dictionary<EgzaminTyp, int> Wyniki { get => wyniki; set => wyniki = value; }
        public void DodajWynik(EgzaminTyp Exam, int ocena)
        {
            wyniki.Add(Exam, ocena);
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"");
            foreach (var item in wyniki)
            {
                builder.Append($"Imie: {imie}, nazwisko: {nazwisko}, wyniki: {wyniki}");
            }
            return builder.ToString();
        }


    }
}
