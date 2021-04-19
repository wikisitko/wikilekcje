using System;
using System.Collections.Generic;
using System.Text;

namespace WikiZadaniaLINQ
{
    public enum Kategoria { Nabial, Napoje, Pieczywo, Przekaski, Mieso }

    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public Kategoria Kategoria { get; set; }
        public Sklep Skep { get; set; }
    }
}
