using Microsoft.EntityFrameworkCore; //to ma byc dopsiane zeby z baz korzystac
using System;
using System.Collections.Generic;
using System.Text;

namespace BazyDanych_Lekcja
{
    //KROK 2 Instalacja w konsoli
    //aby byl dostepny DbContext trzeba w konsoli nuget (Package Manager Console) wpisac taka komende
    //Install-Package Microsoft.EntityFrameworkCore.SqlServer
    //Install-Package Microsoft.EntityFrameworkCore.Tools

    //KROK 3 stworzenie klasy do polaczenia SQL
    class Baza : DbContext
    {
        //KROK 4 stworzenie DbSeta z nazwa tabeli (tutaj Osoby)
        //w nawiasach <> nazwa klasy ktora reprezentuje model
        public DbSet<Osoba> Osoby { get; set; } //tutaj beda przechowywane dane z tabeli Osoba

        //connection string - tekst opisujacy wszystkie parametry polaczenia z serwerem SQL
        //Server=localhost;Database=master;Trusted_Connection=True;

        //KROK 5 umieszczenie connection stringa w takiej funkcji (czyli po prostu skopiuj)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TIP jesli chcesz miec nowa baze danych pod podmien napis MojaBaza
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MojaBaza;Trusted_Connection=True;");
        }
    }

    //KROK 6 dodanie migracji (2 komendy w konsoli)
    //WARNING
    //jesli w swoim modelu dokonalas jakis zmian (np dodanie kolumny/pole, zmiana typu pola) to trzeba wykonac kolejna migracje

    //majac wszystkie klasy opisujace baze jak ja stworzyc fizycznie na serwerze?
    //piszemy w package manager console:
    //add-migrations "Initial"
    //update-database -verbose
}
