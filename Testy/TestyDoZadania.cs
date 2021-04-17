using System;
using System.Collections.Generic;
using Teksty_Zadanie;
using Xunit;

namespace Testy
{
    public class TestyDoZadania
    {
        private const string GazetaPolskaName = "Gazeta Polska";

        //trzeba dodaj odwolanie do tamtego projektu (na drzewku) Dependencies -> Add Project Referencje i wskazac odpowiednia nazwe projektu
        //nastepnie trzeba zrobiæ using odpowiedniego namespace (skrot alt + enter)
        //testowane klasy i inne zalezne od nich klasy powinny buc publiczne zeby mozna bylo ich uzyc w testach
        [Fact] //funkcja w ktorej wykonuje sie test
        public void ArtykulWartoscGazetaPolska()
        {
            Artykul artykul = new Artykul("12.04.2020", GazetaPolskaName, "12345566789");
            Assert.Equal(0, artykul.ObliczWartosc());
        }

        [Fact]
        public void KsiazkaWartosc()
        {
            string tresc = "testowa tresc";
            Ksiazka ksiazka = new Ksiazka("Testowy", "Testowy tytul", tresc);
            Assert.Equal(tresc.Length * 0.5, ksiazka.ObliczWartosc());
        }

        [Fact]
        public void KsiazkaWartoscPrata()
        {
            string tresc = "testowa tresc";
            Ksiazka ksiazka = new Ksiazka("Stephen Prata", "Testowy tytul", tresc);
            Assert.Equal(tresc.Length * 0.7, ksiazka.ObliczWartosc());
        }
    }
}
