using System;
using System.Linq;
using Xunit;
using Zadanka14_KursZlota;

namespace TestProject1KursyZlota
{
    public class UnitTest1
    {
        private const string KursyAdres = @"http://api.nbp.pl/api/cenyzlota/last/30/?format=json";

        [Fact]
        public void SzukajNiepoprawnaData()
        {
            var kursy = new Kursy(KursyAdres);
            Assert.Null(kursy.Szukaj(DateTime.Now.AddDays(1)));
        }

        [Fact]
        public void TanszeNiz()
        {
            const int prog = 230;
            var kursy = new Kursy(KursyAdres);
            var wynik = kursy.TanszeNiz(prog);
            foreach (var item in wynik)
            {
                Assert.InRange(item.cena, 0, prog);
            }
        }

        [Fact]
        public void TanszeNizLINQ()
        {
            const int prog = 230;
            Assert.True(new Kursy(KursyAdres).TanszeNiz(prog).All(x => x.cena < prog));
        }
    }
}
