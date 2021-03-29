using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zadanka17_Baza
{
    class User
    {
        [Key]
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
    }
}
