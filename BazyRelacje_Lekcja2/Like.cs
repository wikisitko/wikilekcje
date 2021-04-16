using System;
using System.Collections.Generic;
using System.Text;

namespace BazyRelacje_Lekcja2
{
    public class Like
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
