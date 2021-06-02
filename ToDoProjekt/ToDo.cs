using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoProjekt
{
    public class ToDo
    {
        private Baza baza;

        public ToDo()
        {
            baza = new Baza();
        }

        public ToDo(Baza baza)
        {
            this.baza = baza;
        }
        
        public void DodajZadanie(string opis, DateTime termin, Kategoria kategoria, bool save = true)
        {
            Zadanie zadanie1 = new Zadanie()
            {
                Opis = opis,
                Termin = termin,
                Kategoria = kategoria,
                CzyZrobione = false
            };
            baza.Zadania.Add(zadanie1);
            if(save)
            {
                baza.SaveChanges();
            }
        }
        public List<Zadanie> PobierzListeZadan()
        {
            return baza.Zadania.ToList();            
        }
        public void UsunZadanie(int number, bool save = true)
        {
            foreach (var zadanie in baza.Zadania)
            {
                if (zadanie.Id == number)
                {
                    baza.Zadania.Remove(zadanie);
                }
            }
            if (save)
            {
                baza.SaveChanges();
            }
        }
        public void OznaczJakoWykonane(int number, bool save = true)
        {
            foreach (var zadanie in baza.Zadania)
            {
                if (zadanie.Id == number)
                {
                    zadanie.CzyZrobione = true;
                }
            }
            if (save)
            {
                baza.SaveChanges();
            }
        }
        public List<Zadanie> OdfiltrujNiewykonane()
        {
            //List<Zadanie> niewykonane = new List<Zadanie>();
            //foreach (var Zadanie in baza.Zadania.ToList())
            //{
            //    if (Zadanie.CzyZrobione == false)
            //    {
            //        niewykonane.Add(Zadanie);
            //    }
            //}
            //return niewykonane;
            return baza.Zadania.ToList().FindAll(x => !x.CzyZrobione);
        }
        public List<Zadanie> OdfiltrujKategorie(Kategoria kategoria)
        {
            //List<Zadanie> wazne = new List<Zadanie>();
            //foreach (var Zadanie in baza.Zadania.ToList())
            //{
            //    if (Zadanie.Kategoria == "wazne")
            //    {
            //        wazne.Add(Zadanie);
            //    }
            //}
            //return wazne;
            return baza.Zadania.Where(x => x.Kategoria == kategoria).ToList();
        }
        public List<Zadanie> PrzeterminowaneZadania()
        {
            //foreach (var zadanie in baza.Zadania)
            //{
            //    if (zadanie.CzyZrobione == false && zadanie.Termin < DateTime.Now)
            //    {
            //        Console.WriteLine($"Termin zadania {zadanie.Id} minął {zadanie.Termin}.");
            //    }
            //}
            return baza.Zadania.ToList().FindAll(x => x.CzyZrobione == false && x.Termin < DateTime.Now);
        }
    }
}
