using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod_UPEL
{
    public class SamochodK
    {
        private string id;
        public enum Marka { Opel, Volvo, Fiat, Suzuki, Toyota, Mercedes }
        private WlascicielK posiadacz;
        private long licznik;

        public string Id { get => id; set => id = value; }

        public SamochodK()
        {
            licznik = 0;
        }
        public SamochodK(string id, WlascicielK posiadacz, long licznik)
        {
            this.Id = $"CAR\\{licznik.ToString().PadLeft(5, '0')}";
            this.posiadacz = posiadacz;
            this.licznik = licznik;
            licznik++;
        }

        public override string ToString()
        {
            return $"{Id}: {posiadacz}"; //brakuje
        }
    }
}
