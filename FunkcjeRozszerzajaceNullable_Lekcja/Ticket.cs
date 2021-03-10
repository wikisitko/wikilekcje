using System;
using System.Collections.Generic;
using System.Text;

namespace FunkcjeRozszerzajaceNullable_Lekcja
{
    class Ticket
    {
        private string description;
        private int priority;
        private DateTime? resolutionDate; //? - zrobilismy z datetime typ referencyjny i teraz mozna tam wsadzic nulla

        public Ticket(string description, int priority)
        {
            this.description = description;
            this.priority = priority;
        }
        
        public string Description { get => description; set => description = value; }
        public int Priority { get => priority; set => priority = value; }
        public DateTime? ResolutionDate { get => resolutionDate; set => resolutionDate = value; }
    }
}
