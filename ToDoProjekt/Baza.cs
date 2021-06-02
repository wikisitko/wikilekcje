using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoProjekt
{
    public class Baza : DbContext
    {
        //KROK 4 stworzenie DbSeta z nazwa tabeli (tutaj Osoby)
        //w nawiasach <> nazwa klasy ktora reprezentuje model
        public DbSet<Zadanie> Zadania { get; set; } //tutaj beda przechowywane dane z tabeli Osoba
        public DbSet<User> Userzy { get; set; } //tutaj beda przechowywane dane z tabeli Osoba

        //connection string - tekst opisujacy wszystkie parametry polaczenia z serwerem SQL
        //Server=localhost;Database=master;Trusted_Connection=True;

        //KROK 5 umieszczenie connection stringa w takiej funkcji (czyli po prostu skopiuj)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TIP jesli chcesz miec nowa baze danych pod podmien napis MojaBaza
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BazaToDo;Trusted_Connection=True;");
        }
    }
}
