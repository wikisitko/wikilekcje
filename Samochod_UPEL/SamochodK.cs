using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod_UPEL
{
    public enum Marka { Opel, Volvo, Fiat, Suzuki, Toyota, Mercedes }
    public class SamochodK
    {
        private string id;

        private Marka markaSamochodu;
        private WlascicielK posiadacz;
        private static long licznik = 0;

        public string Id { get => id; set => id = value; }
        public WlascicielK Posiadacz { get => posiadacz; set => posiadacz = value; }

        public SamochodK(WlascicielK posiadacz, Marka markaSamochodu)
        {
            this.Id = $"CAR\\{licznik.ToString().PadLeft(5, '0')}";
            this.Posiadacz = posiadacz;
            licznik++;
            this.markaSamochodu = markaSamochodu;
        }

        public override string ToString()
        {
            return $"{Id}: {Posiadacz}, {markaSamochodu}";
        }
    }
}
