using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BazyRelacje_Lekcja
{
    class DB : DbContext
    {
        //KROK 4 stworzenie DbSeta z nazwa tabeli (tutaj Osoby)
        //w nawiasach <> nazwa klasy ktora reprezentuje model
        public DbSet<Client> Clients { get; set; } //tutaj beda przechowywane dane z tabeli Osoba
        public DbSet<Complaint> Complaints { get; set; } //tutaj beda przechowywane dane z tabeli Osoba

        //connection string - tekst opisujacy wszystkie parametry polaczenia z serwerem SQL
        //Server=localhost;Database=master;Trusted_Connection=True;

        //KROK 5 umieszczenie connection stringa w takiej funkcji (czyli po prostu skopiuj)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TIP jesli chcesz miec nowa baze danych pod podmien napis MojaBaza
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MojaBaza2;Trusted_Connection=True;");
        }
    }
}
