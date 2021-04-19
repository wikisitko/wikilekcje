using System;
using System.Collections.Generic;
using WikiZadaniaLINQ;
using Xunit;

namespace Testy
{
    public class UnitTest1
    {
        [Fact]
        public void ProduktySklep()
        {
            var produkty = GetProdukty();
            var sklepy = GetSklepy();
            int id = sklepy[0].Id;
            var oczekiwany = new List<Produkt>();

            for (int i = 0; i < produkty.Count; i++)
            {
                produkty[i].Skep = sklepy[i%sklepy.Count];
                if(sklepy[i % sklepy.Count].Id == id)
                {
                    oczekiwany.Add(produkty[i]);
                }
            }

            var wynik = Program.ProduktySklep(produkty, sklepy[0]);
            Assert.Equal(oczekiwany, wynik);
        }

        [Fact]
        public void ProduktySklepNull()
        {
            var wynik = Program.ProduktySklep(null, null);
            Assert.Null(wynik);
        }

        [Fact]
        public void GetProdukt()
        {
            var produkty = GetProdukty();
            foreach (var item in produkty)
            {
                Assert.Equal(item, Program.GetProdukt(produkty, item.Id));
            }
        }

        [Fact]
        public void GetProduktBlednyId()
        {
            var produkty = GetProdukty();
            Assert.Null(Program.GetProdukt(produkty, -100));
        }

        [Fact]
        public void ProduktyZKategorii()
        {
            var produkty = GetProdukty();
            Kategoria kat = Kategoria.Napoje;

            var wynik = Program.ProduktyZKategorii(produkty, kat);

            int ile = 0;
            var oczekiwana = new string[] { "Coca-cola", "7up" };
            foreach (var item in wynik)
            {
                Assert.Equal(oczekiwana[ile], item);
                ile++;
            }
            Assert.Equal(2, ile);
        }

        private List<Produkt> GetProdukty()
        {
            return new List<Produkt>()
            {
                new Produkt {Id = 1, Ilosc = 4, Kategoria = Kategoria.Mieso, Nazwa = "Podudzie z kurczaka"},
                new Produkt {Id = 2, Ilosc = 14, Kategoria = Kategoria.Mieso, Nazwa = "Piers z indyka"},

                new Produkt {Id = 3, Ilosc = 7, Kategoria = Kategoria.Napoje, Nazwa = "Coca-cola"},
                new Produkt {Id = 4, Ilosc = 2, Kategoria = Kategoria.Napoje, Nazwa = "7up"},

                new Produkt {Id = 5, Ilosc = 9, Kategoria = Kategoria.Przekaski, Nazwa = "Lays solone"},
                new Produkt {Id = 6, Ilosc = 10, Kategoria = Kategoria.Przekaski, Nazwa = "Lays zielona cebulka"},

                new Produkt {Id = 7, Ilosc = 7, Kategoria = Kategoria.Nabial, Nazwa = "Serek wiejski"},
                new Produkt {Id = 8, Ilosc = 11, Kategoria = Kategoria.Nabial, Nazwa = "Mleko bez laktozy"},
            };
        }

        private List<Sklep> GetSklepy()
        {
            return new List<Sklep>()
            {
                new Sklep{Id=1, Nazwa="Biedronka", Adres="ul. Marymocnka, Warszawa"},
                new Sklep{Id=2, Nazwa="Zabka", Adres="ul. Kasprowicza, Warszawa"},
                new Sklep{Id=3, Nazwa="Biedronka", Adres="ul. Orzechowa, Biala Podlaska"},
                new Sklep{Id=4, Nazwa="Lidl", Adres="ul. Boguslawskiego, Warszawa"},
                new Sklep{Id=5, Nazwa="Kaufland", Adres="ul. Winogrady, Poznan"},
                new Sklep{Id=6, Nazwa="Biedronka", Adres="ul. Podlesna, Warszawa"},
            };
        }
    }
}
