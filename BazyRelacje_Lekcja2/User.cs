using System;
using System.Collections.Generic;
using System.Text;

namespace BazyRelacje_Lekcja2
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Post> Posts { get; set; }
        public List<Like> Likes { get; set; }
    }
}
