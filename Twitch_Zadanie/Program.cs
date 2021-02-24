using System;
using System.Collections.Generic;

namespace Twitch_Zadanie
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //if (Kwota <= 0)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}

            //try
            //{ 
            //  
            //}

            Tipo t = new Tipo("gucci412", "jesteś super nie zmieniaj się", 5, "20/02/2021", Typ.tekstowy);
            Tipo t2 = new Tipo("kolip", "ile to 100?", 10, "05/01/2021", Typ.tekstowy);
            Tipo t3 = new Tipo("zaba123", "super", 50, "01/01/2021", Typ.głosowy);

            Paypal p = new Paypal("tombrajder", "D:", 15, "20/02/2020", "125412698511456587451214");
            Paypal p2 = new Paypal("captainjack", "Księżyc świeci, Śpią już dzieci, Śpią mama i tata.Nie śpi pilot, bo lata.Pociemniał dookoła świat.Śpi siostra i śpi też brat.I Ty zaśnij też! Zasypiam ja, zasypia jeż.", 54, "19/05/2020", "125412698511456587451214");
            Paypal p3 = new Paypal("tomekzlomek", "D:", 5.70, "04/01/2020", "125412698511456587451214");

            List<Donate> donejty = new List<Donate>();
            donejty.Add(t);
            donejty.Add(t2);
            donejty.Add(t3);
            donejty.Add(p);
            donejty.Add(p2);
            donejty.Add(p3);

            double suma = 0;
            foreach (var don in donejty)
            {
                Console.WriteLine(don);
                Console.WriteLine(Math.Round(don.KwotaNetto(), 2));
                suma += don.KwotaNetto();
            }

            Console.WriteLine("\n");
            Console.WriteLine($"All netto: {suma}");
            Console.WriteLine(Donate.MaxKwota(donejty));

           
        }
    }
}
