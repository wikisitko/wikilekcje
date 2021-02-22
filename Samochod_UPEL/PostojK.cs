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

        public PostojK(string dataRozpoczecia)
        {
            //this.zakonczenie = zakonczenie;
            //this.samochod = 
            this.dataRozpoczecia = DateTime.Parse(dataRozpoczecia);
            //this.dataZakonczenia = dataZakonczenia;
        }

        public PostojK()
        {
            zakonczenie = false; 
        }

        public DateTime Zakoncz(PostojK postoj)
        {
            zakonczenie = true;
            dataZakonczenia = DateTime.Now;

            return dataZakonczenia;
        }
        public double ObliczOplate()
        {
            double czas = dataZakonczenia.Hour - dataRozpoczecia.Hour;

            //nie umiem wyciagnac polisy :(

            return czas * 10;
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
