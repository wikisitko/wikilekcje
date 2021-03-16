using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Zadanka14_KursZlota
{
    class SortujCena : IComparer<KursZlota>
    {
        public int Compare(KursZlota x, KursZlota y)
        {
            return x.Cena.CompareTo(y.Cena);
        }
    }
    class SortujData : IComparer<KursZlota>
    {
        public int Compare(KursZlota x, KursZlota y)
        {
            return x.Data.CompareTo(y.Data);
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
        public double? Szukaj(DateTime data)
        {
            if (data == Data) //nie umiem się dostać do tych danych z klasy KursZlota
            {
                return Cena;
            }
            else
            {
                return null;
            }
        }
    }
}
