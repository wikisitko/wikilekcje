using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoProjekt
{
    class ToDo
    {
        private Baza baza;

        public ToDo()
        {
            baza = new Baza();
        }
        
        public void DodajZadanie(string opis, DateTime termin, string kategoria)
        {
            Zadanie zadanie1 = new Zadanie()
            {
                Opis = opis,
                Termin = termin,
                Kategoria = kategoria,
                CzyZrobione = false
            };
            baza.Zadania.Add(zadanie1);
            baza.SaveChanges();
        }
        public List<Zadanie> PobierzListeZadan()
        {
            return baza.Zadania.ToList();            
        }
    }
}
