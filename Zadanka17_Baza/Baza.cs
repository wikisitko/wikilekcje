using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka17_Baza
{
    [Keyless]
    class Baza : DbContext
    {
        public DbSet<User> Userzy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MojaBaza;Trusted_Connection=True;");
        }


    }
}
