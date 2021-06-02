using System;
using Xunit;
using ToDoProjekt;
using System.Linq;
using System.Collections.Generic;

namespace ToDoTests
{
    public class UnitTest1
    {
        const bool SaveDb = true;

        [Fact]
        public void DodajZadanieTest()
        {
            string opis = "kupic mleko";
            DateTime data = new DateTime(2021, 03, 13);
            Kategoria kategoria = Kategoria.Zakupy;


            Baza baza = new Baza();
            ToDo todo = new ToDo(baza);
            todo.DodajZadanie(opis, data, kategoria, SaveDb);
            
            Zadanie wynik = baza.Zadania.ToList().Find(x => x.Opis == opis && x.Termin == data && x.Kategoria == kategoria);
            Assert.NotNull(wynik);

            //sprzatanie bazy
            baza.Zadania.Remove(wynik);
            baza.SaveChanges();
        }
        [Fact]
        public void OdfiltrujKategorieTest()
        {
            Zadanie zadanie1 = new Zadanie {Opis = "kupic spodnie", Kategoria = Kategoria.Zakupy, Termin = DateTime.Now};
            Zadanie zadanie2 = new Zadanie {Opis = "kupic buty", Kategoria = Kategoria.Zakupy, Termin = DateTime.Now};
            Zadanie zadanie3 = new Zadanie {Opis = "umyc okna", Kategoria = Kategoria.Dom, Termin = DateTime.Now};

            Baza baza = new Baza();
            ToDo todo = new ToDo(baza);

            baza.Add(zadanie1);
            baza.Add(zadanie2);
            baza.Add(zadanie3);
            baza.SaveChanges();

            var wynik = todo.OdfiltrujKategorie(Kategoria.Zakupy);

            Assert.Contains(wynik, x => x.Opis == zadanie1.Opis && x.Termin == zadanie1.Termin && x.Kategoria == zadanie1.Kategoria);
            Assert.Contains(wynik, x => x.Opis == zadanie2.Opis && x.Termin == zadanie2.Termin && x.Kategoria == zadanie2.Kategoria);

            baza.Remove(zadanie1);
            baza.Remove(zadanie2);
            baza.Remove(zadanie3);
            baza.SaveChanges();
        }

    [Fact]
    public void UsunZadanieTest()
        {
            Zadanie zadanie4 = new Zadanie { Opis = "umyc zeby", Kategoria = Kategoria.Wazne, Termin = DateTime.Now };
            Baza baza = new Baza();
            baza.Add(zadanie4);
            baza.SaveChanges();

            ToDo todo = new ToDo(baza);
            todo.UsunZadanie(zadanie4.Id);

            Assert.False(baza.Zadania.Contains(zadanie4));
        }

        [Fact]
        public void ZaznaczWykonaneTest()
        {
            Zadanie zadanie5 = new Zadanie { Opis = "kup paste do zebow", Kategoria = Kategoria.Dom, Termin = DateTime.Now };
            Baza baza = new Baza();
            baza.Add(zadanie5);
            baza.SaveChanges();

            ToDo todo = new ToDo(baza);
            todo.OznaczJakoWykonane(zadanie5.Id);

            Assert.True(baza.Zadania.Find(zadanie5.Id).CzyZrobione);
            baza.Zadania.Remove(zadanie5);
            baza.SaveChanges();
        }

    }
}
