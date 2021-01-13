using System;
using System.Collections.Generic;

namespace DziedziczenieLekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            Klient k = new Klient("Ola", "Kowalska", "5787965412", 100);
            KlientFirma f = new KlientFirma("Jan", "Kowalski", "12658745962", 200, "5741256987", true);

            //prawilna kopia:
            //KlientFirma kopia = new KlientFirma(f.Imie, f.Nazwisko, f.Tel, f.Kwota, f.Nip, f.Vat);

            KlientFirma x = f; //TUTAJ OBIKET SIE NIE KOPIUJE, jedynie kopiuje sie odniesienie na niego, dla obiektow tworzonych przez new (tablice, listy, obiekty klas)
            x.Nip = "hacked";

            Console.WriteLine(f.Nip);
            Console.WriteLine(x.Nip);

            int a = 5;
            int b = a; //Jesli cos nie jest tworzenie przez slowo new (typy proste: int float string) to tutaj dojdzie do skopiowania wartosci
            b = 3;
            Console.WriteLine(a);
            Console.WriteLine(b);

            KlientFirma firma = new KlientFirma("Jan", "Kowalski", "12658745962", 200, "5741256987", true);
            Klient klient = firma;
            Console.WriteLine(klient.Kwota);

            //List<Klient> klienci = new List<Klient>();
            //klienci.Add(new Klient("Ola", "Kowalska", "5787965412", 100));
            //klienci.Add(new Klient("Ada", "Nowak", "5745965845", 120));
            //klienci.Add(new Klient("Iga", "Piekarz", "9874521456", 105));
            //klienci.Add(new KlientFirma("Jan", "Kowalski", "12658745962", 200, "5741256987", true));

            //foreach (var klient in klienci)
            //{
            //    Console.WriteLine(klient);
            //}
        }
    }
}
