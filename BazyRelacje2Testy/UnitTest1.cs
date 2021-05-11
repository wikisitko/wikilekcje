using BazyRelacje_Lekcja2;
using System;
using System.Collections.Generic;
using Xunit;

namespace BazyRelacje2Testy
{
    public class UnitTest1
    {
        [Fact]
        public void ListExtension()
        {
            List<int> liczby = new List<int>() { 5, 4, 3, 1 };
            Assert.Equal("5,4,3,1,", liczby.ElementsToString());
        }

        [Fact]
        public void Logowanie()
        {
            var login = "testowy_user";
            var pass = "testowe_haslo";
            var email = "testowy_mail@test.pl";
            var db = new DbConnection();
            db.CreateAccount(email: email, login: login, password: pass);
            var user = db.LogIn(login: login, password: pass);
            Assert.NotNull(user);
            Assert.Equal(login, user.Login);
            Assert.Equal(pass, user.Password);
            Assert.Equal(email, user.Email);
        }
    }
}
