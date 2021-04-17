using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BazyRelacje_Lekcja2
{
    class DbConnection
    {
        private DB db;

        public DbConnection()
        {
            db = new DB();
        }

        public bool CreateAccount(string login, string email, string password)
        {
            if(db.Users.Any(x => x.Login == login))
            {
                return false;
            }

            db.Users.Add(new User()
            {
                Login = login,
                Email = email,
                Password = password
            });
            db.SaveChanges();
            return true;
        }

        public User LogIn(string login, string password)
        {
            return db.Users.Include(x => x.Likes).Include(x => x.Posts).ToList().Find(x => x.Login == login && x.Password == password);
        }

        public List<Post> GetAllPosts()
        {
            //Include - przy ladowaniu postow laduje tez elementy z innych tabel (np dane o userze czy lajkach)
            //jesli dane z naszej tabeli odnosza sie do innej tabeli do musimy uzyc polecenia include i dodac te inne tabele
            return db.Posts.Include(x => x.Owner).Include(x => x.Likes).ToList();
        }

        public bool AddPost(User user, string text)
        {
            if (db.Users.Where(x => x.Id == user.Id).First() == null)
            {
                return false; //funkcja zwraca czy udalo sie dodac like do bazy (w tym przypadku nie)
            }

            Post post = new Post
            {
                Text = text,
                Date = DateTime.Now,
                Owner = user
            };
            db.Posts.Add(post);
            db.SaveChanges();
            return true;
        }

        public bool AddLike(User liker, Post post)
        {
            if(db.Users.Where(x => x.Id == liker.Id).First() == null)
            {
                return false; //funkcja zwraca czy udalo sie dodac like do bazy (w tym przypadku nie)
            }

            if (db.Posts.Where(x => x.Id == post.Id).First() == null)
            {
                return false; //funkcja zwraca czy udalo sie dodac like do bazy (w tym przypadku nie)
            }

            //sprawdzamy czy ta osoba nie oddala juz like
            if (db.Likes.Where(x => x.User.Id == liker.Id && x.Post.Id == post.Id).Count() != 0)
            {
                return false; //funkcja zwraca czy udalo sie dodac like do bazy (w tym przypadku nie)
            }

            Like like = new Like
            {
                Date = DateTime.Now,
                Post = post,
                User = liker
            };
            db.Likes.Add(like);
            db.SaveChanges();
            return true;
        }
    }
}
