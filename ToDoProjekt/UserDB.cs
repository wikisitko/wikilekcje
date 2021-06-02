using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoProjekt
{
    public class UserDB
    {
        private Baza baza;

        public UserDB()
        {
            baza = new Baza();
        }

        public UserDB(Baza baza)
        {
            this.baza = baza;
        }

        public User DodajUsera(string login, string haslo)
        {
            if(login == null || login.Length == 0 || haslo == null || haslo.Length == 0)
            {
                return null;
            }

            var wynik = baza.Add(new User
            {
                Login = login,
                Haslo = haslo
            });
            baza.SaveChanges();
            return wynik.Entity;
        }

        public User PobierzUsera(string login, string haslo)
        {
            return baza.Userzy.Where(x => x.Login == login && x.Haslo == haslo).FirstOrDefault();
        }
    }
}
