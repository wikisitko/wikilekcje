using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Zadanka14_KursZlota
{
    class Kursy : //IComparable<Kursy>
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

       

        public List<KursZlota> SortujCena()
        {
            lista.Sort();
            lista.Reverse();
            return lista;
        }

        public override string ToString() //powinien zapisywac do stringa zawartość listy kursów
        {
            StringBuilder builder = new StringBuilder();
            //foreach (var kurs in lista)
            //{
            //    foreach (var item in )
            //    {

            //    }

            //}
            
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    foreach (var item in collection)
            //    {

            //    }
            //    builder.AppendLine(lista[i]);
            //}
            
            return base.ToString();
        }

        //public double? Szukaj(DateTime data)
        //{
        //    return null;
        //}

        //public List<KursZlota> TanszeNiz(double? cena)
        //{

        //}
    }
}
