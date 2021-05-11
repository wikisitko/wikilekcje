using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoProjekt
{
    class Zadanie
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public DateTime Termin { get; set; }
        public string Kategoria { get; set; }
        public bool CzyZrobione { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Opis}";
        }
    }
}
