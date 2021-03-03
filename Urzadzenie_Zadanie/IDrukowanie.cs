using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    public interface IDrukowanie
    {
        //int iloscTuszu();

        int IloscTuszu { get; }

        string DrukujMetoda();

        string Drukuj() //chcialabym zeby mi to tutaj pobieralo ilosc tuszu i jak zbyt malo to sie sypalo
        {
            if (IloscTuszu == 0)
            {
                throw new BrakTuszuException();
            }  
            else
            {
                return DrukujMetoda();
            }
           
        }
    }
}
