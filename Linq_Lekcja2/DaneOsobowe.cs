using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lekcja2
{
    class DaneOsobowe
    {
        private int wiek;
        private string miasto;

        public DaneOsobowe(int wiek, string miasto)
        {
            this.Wiek = wiek;
            this.Miasto = miasto;
        }
        public string Miasto { get => miasto; set => miasto = value; }
        public int Wiek { get => wiek; set => wiek = value; }

        public override string ToString()
        {
            return $"{miasto} {Wiek}";
        }
    }
}
