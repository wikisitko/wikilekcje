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

            Tipo t = new Tipo(1, "gucci412", "jesteś super nie zmieniaj się", 5, "20/02/2021", Typ.tekstowy);
            Tipo t2 = new Tipo(1, "kolip", "ile to 100?", 10, "05/01/2021", Typ.tekstowy);
            Tipo t3 = new Tipo(1, "zaba123", "super", 50, "01/01/2021", Typ.głosowy);

            Paypal p = new Paypal(2, "tombrajder", "D:", 15, "20/02/2020", "125412698511456587451214");
            Paypal p2 = new Paypal(2, "captainjack", "Księżyc świeci, Śpią już dzieci, Śpią mama i tata.Nie śpi pilot, bo lata.Pociemniał dookoła świat.Śpi siostra i śpi też brat.I Ty zaśnij też! Zasypiam ja, zasypia jeż.", 54, "19/05/2020", "125412698511456587451214");
            Paypal p3 = new Paypal(2, "tomekzlomek", "D:", 5.70, "04/01/2020", "125412698511456587451214");

            List<Donate> donejty = new List<Donate>();
            donejty.Add(t);
            donejty.Add(t2);
            donejty.Add(t3);
            donejty.Add(p);
            donejty.Add(p2);
            donejty.Add(p3);
            
            double MaxKwota() //jak to zrobic zeby bylo poza main :(
            {
                double max = 0;
                foreach (var don in donejty)
                {
                    if (don.Kwota > max) 
                    {
                        max = don.Kwota;
                    }
                }
                return max;
            }

            foreach (var don in donejty)
            {
                Console.WriteLine(don.KwotaNetto()); 
            }
            Console.WriteLine("\n");
            Console.WriteLine(MaxKwota());

           
        }
    }
}
