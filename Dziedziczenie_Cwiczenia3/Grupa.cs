using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Cwiczenia3
{
    class Grupa
    {
        private Nauczyciel nauczyciel; //kompozycja (tylko jeden obiekt)
        private List<Uczen> uczniowie; //agregacja (0 lub wiecej obiektow)
        private string nazwa;

        public Grupa(Nauczyciel nauczyciel, string nazwa)
        {
            this.nauczyciel = nauczyciel;
            this.nazwa = nazwa;
            this.uczniowie = new List<Uczen>();
        }

        public void DodajUcznia(Uczen u)
        {
            uczniowie.Add(u);
        }

        //public override string ToString()
        //{
        //    string text = $"Grupa: {nazwa}, Nauczyciel: {nauczyciel}\n";
        //    text += "Uczniowie:\n";
        //    foreach (var uczen in uczniowie)
        //    {
        //        text += uczen + "\n";
        //    }
        //    return text;
        //}

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Grupa: {nazwa}, Nauczyciel: {nauczyciel}");
            builder.AppendLine("Uczniowie:");

            foreach (var uczen in uczniowie)
            {
                builder.AppendLine(uczen.ToString());
            }
            return builder.ToString();
        }

        public double SredniaOcen()
        {
            double suma = 0;
            foreach (var uczen in uczniowie)
            {
                suma += uczen.Ocena;
            }
            return suma / uczniowie.Count;
        }

        public int IleOsob(Plec p)
        {
            int licznik = 0;
            foreach (var os in uczniowie)
            {
                if (os.Plec == p)
                {
                    licznik++;
                }
            }
            return licznik;
        }
    }
}
