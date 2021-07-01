using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace serializacjaJSONzadanie
{
    class Baza : DbContext
    {
        public DbSet<Osoba> Przypadki { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=SerializacjaBaza;Trusted_Connection=True;");
        }
    }
}
