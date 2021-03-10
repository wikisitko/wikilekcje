using System;

namespace Zadania13_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Alan", "Balan");
            //s1.wyniki.Add(EgzaminTyp.ASiD, 5);
            s1.DodajWynik(EgzaminTyp.ASiD, 5);
            s1.DodajWynik(EgzaminTyp.PROE, 4);
            Console.WriteLine(s1);

            Student s2 = new Student("Marek", "Barek");
            s2.DodajWynik(EgzaminTyp.PROE, 5);
            Console.WriteLine(s2);
        }
    }
}
