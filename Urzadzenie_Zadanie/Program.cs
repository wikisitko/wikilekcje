using System;
using System.Collections.Generic;

namespace Urzadzenie_Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Drukarka d1 = new Drukarka("FP1000", "Lexmark", 10);
            UrzadzenieWielofunkcyjne uw1 = new UrzadzenieWielofunkcyjne("VX490", "Lexmark", rodzajPolaczenia.Wifi);
            UrzadzenieWielofunkcyjne uw2 = new UrzadzenieWielofunkcyjne("CDR450", "Lexmark", rodzajPolaczenia.Bluetooth);
            Skaner s1 = new Skaner("MB223", "Lexmark", 10);

            List<IDrukowanie> urzadzeniaDrukujace = new List<IDrukowanie>();
            List<ISkanowanie> urzadzeniaSkanujace = new List<ISkanowanie>();

            urzadzeniaDrukujace.Add(d1);
            urzadzeniaDrukujace.Add(uw1);
            urzadzeniaSkanujace.Add(uw1);
            urzadzeniaSkanujace.Add(s1);

            foreach (var item in urzadzeniaDrukujace)
            {
                Console.WriteLine(item.Drukuj()); 
            }

            foreach (var item in urzadzeniaSkanujace)
            {
                Console.WriteLine(item.Skanuj());
            }
        }
    }
}
