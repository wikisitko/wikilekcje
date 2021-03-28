using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BazaDanych_Produkt
{
    class Baza : DbContext
    {
        public DbSet<Produkt> Produkty { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MojaBaza;Trusted_Connection=True;");
        }
    }
}

