using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Zadanka14_KursZlota
{
    class CenaComparer : IComparer<KursZlota>
    {
        public int Compare(KursZlota x, KursZlota y)
        {
            return x.cena.CompareTo(y.cena);
        }
    }
    class DataComparer : IComparer<KursZlota>
    {
        public int Compare(KursZlota x, KursZlota y)
        {
            return x.data.CompareTo(y.data);
        }
    }
    public class Kursy
    {
        private List<KursZlota> lista;
        private string adres;

        public Kursy(string adres)
        {
            WebClient client = new WebClient();
            string strona = client.DownloadString(adres);
            lista = JsonSerializer.Deserialize<List<KursZlota>>(strona);
            if (lista == null || lista.Count == 0)
            {
                throw new NoResultsException();
            }
            this.adres = adres;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Adres: ").AppendLine(adres);
            foreach (var item in lista)
            {
                builder.AppendLine(item.ToString());
            }
            return builder.ToString();
        }

        public void SortujCena()
        {
            lista.Sort(new CenaComparer());
        }

        public void SortujData()
        {
            lista.Sort(new DataComparer());
        }

        public double? Szukaj(DateTime data)
        {
            foreach (var item in lista)
            {
                if(item.data == data)
                {
                    return item.cena;
                }
            }

            return null;
        }

        public List<KursZlota> TanszeNiz(int? cena)
        {
            if(cena == null)
            {
                return lista;
            }

            List<KursZlota> wynik = new List<KursZlota>();
            foreach (var item in lista)
            {
                if (item.cena < cena)
                {
                    wynik.Add(item);
                }
            }
            return wynik;
        }
    }
}
