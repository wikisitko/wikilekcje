using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_Koszyk
{
    class Koszyk
    { 
        public List<Telefon> ListaTelefonow;


        public Koszyk() => ListaTelefonow = new List<Telefon>();


        public void DodajProdukt(string marka1, string model1, int cena1)
        {
            Telefon t1 = new Telefon(marka1, model1, cena1); 
            ListaTelefonow.Add(t1);

            /*Telefon t1 = new Telefon("Samsung", "A30", 100);
            Telefon t2 = new Telefon("Samsung", "A40", 1000);
            Telefon t3 = new Telefon("Samsung", "A50", 10000);
            Telefon t4 = new Telefon("Samsung", "A60", 100000);

            ListaTelefonow.Add(t1);
            ListaTelefonow.Add(t2);
            ListaTelefonow.Add(t3);
            ListaTelefonow.Add(t4);*/
        }
        
        public int Cena()
        {
            int s = 0;
            for (int i = 0; i < ListaTelefonow.Count; i++) //5 -> 0 1 2 3 4
            {
                s += ListaTelefonow[i].Cena;
            }
            return s;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < ListaTelefonow.Count; i++) 
            {
                s += ListaTelefonow[i].ToString() + "\n";
            }
            return s;
        }
    }
}
