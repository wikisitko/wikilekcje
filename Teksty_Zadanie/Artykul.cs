using System;
using System.Collections.Generic;
using System.Text;

namespace Teksty_Zadanie
{
    class Artykul : Tekst
    {
        private DateTime dataWydania;
        private string nazwaCzasopisma;
        public Artykul(string dataWydania, string nazwaCzasopisma, string tresc) : base(tresc)
        {

            this.dataWydania = DateTime.Parse(dataWydania);
            this.nazwaCzasopisma = nazwaCzasopisma;
        }

        public override double ObliczWartosc()
        {
            if (nazwaCzasopisma == "Gazeta Polska")
            {
                return 0;
            }
            else if (DateTime.Now.Year - dataWydania.Year < 5)
            {
                return tresc.Length * 0.1;
            }
            else
            {
                return tresc.Length * 0.2;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"NAZWA CZASOPISMA: {nazwaCzasopisma}, DATA WYDANIA: {dataWydania}";
        }

        public override string TypTekstu()
        {
            return "Artykul";
        }
    }
}
