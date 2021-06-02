using System;
using Xunit;
using ToDoProjekt;
using System.Linq;

namespace ToDoTests
{
    public class UserTest
    {
        [Fact]
        public void DodanieUseraTest()
        {
            string login = "imprezowalama";
            string haslo = "1234";

            Baza baza = new Baza();
            UserDB userDB = new UserDB();
            User us = userDB.DodajUsera(login, haslo);

            Assert.NotNull(us);
            Assert.Equal(login, us.Login);
            Assert.Equal(haslo, us.Haslo);
            Assert.NotNull(baza.Userzy.Find(us.Id));

            baza.Remove(us);
            baza.SaveChanges();
        }
    }
}
