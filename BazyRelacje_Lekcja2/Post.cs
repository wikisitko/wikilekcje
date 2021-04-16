using System;
using System.Collections.Generic;
using System.Text;

namespace BazyRelacje_Lekcja2
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public User Owner { get; set; }
        public List<Like> Likes { get; set; }
    }
}
