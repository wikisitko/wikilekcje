using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Zadanka14_KursZlota
{
    class Kursy
    {
        protected List<Dictionary<DateTime, double>> lista;
        protected string adres;

        public Kursy(string adres)
        {
            lista = new List<Dictionary<DateTime, double>>();
            lista = JsonSerializer.Deserialize<List<Dictionary<DateTime, double>>>(adres);
            if (lista == null)
            {
                throw new NoResultsException();
            }
            else
            {
                this.adres = adres;
            }

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
    }
}
