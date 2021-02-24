using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod_UPEL
{
    public class PostojK
    {
        private bool zakonczenie;
        SamochodK samochod;
        private DateTime dataRozpoczecia;
        private DateTime dataZakonczenia;

        public PostojK(SamochodK samochod, string dataRozpoczecia)
        {
            zakonczenie = false;
            this.samochod = samochod;
            this.dataRozpoczecia = DateTime.Parse(dataRozpoczecia);
        }

        public DateTime Zakoncz(PostojK postoj)
        {
            zakonczenie = true;
            dataZakonczenia = DateTime.Now;

            return dataZakonczenia;
        }
        public double ObliczOplate()
        {
            double czas = (dataZakonczenia - dataRozpoczecia).TotalHours;

            //nie umiem wyciagnac polisy :(
            if(samochod.Posiadacz.Polisa)
            {
                return czas * 10 * 0.9;

            }
            else
            {
                return czas * 10;
            }
            
        }

        public override string ToString() //brakuje
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Informacje o postoju -> data rozpoczęcia: {dataRozpoczecia}");

            if (zakonczenie)
            {
                builder.AppendLine($"-> data zakończenia {dataZakonczenia}");
            }
            return builder.ToString();
        }
    }
}
