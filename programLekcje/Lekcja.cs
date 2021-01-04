using System;
using System.Collections.Generic;
using System.Text;

namespace programLekcje
{
    class Lekcja
    {
        private string date;
        private string payment;
        private string name;
        private int price;

        public Lekcja(string date, string payment, string name, int price)
        {
            this.date = date;
            this.payment = payment;
            this.name = name;
            this.price = price;
        }

        public string Date { get => date; set => date = value; }
        public string Payment { get => payment; set => payment = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"{date} {payment} {name} {price}\n";
        }
    }
}
