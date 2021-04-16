using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BazyRelacje_Lekcja2
{
    class DB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TIP jesli chcesz miec nowa baze danych pod podmien napis MojaBaza
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MojaBaza10_4;Trusted_Connection=True;");
        }
    }
}
