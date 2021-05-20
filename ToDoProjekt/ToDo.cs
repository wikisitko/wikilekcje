﻿using System;
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
        
        public void DodajZadanie(string opis, DateTime termin, Kategoria kategoria)
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
        public void UsunZadanie(Zadanie doUsuniecia)
        {
            baza.Zadania.Remove(doUsuniecia);
            //baza.SaveChanges();
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
    }
}
