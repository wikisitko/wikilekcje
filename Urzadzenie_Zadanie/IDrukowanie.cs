using System;
using System.Collections.Generic;
using System.Text;

namespace Urzadzenie_Zadanie
{
    public interface IDrukowanie
    {
        int iloscTuszu();
        string Drukuj() //chcialabym zeby mi to tutaj pobieralo ilosc tuszu i jak zbyt malo to sie sypalo
        {
            if (iloscTuszu() < 0)
            {
                throw new UjemnaWartoscException();
            }
            else if (iloscTuszu() == 0)
            {
                throw new BrakTuszuException();
            }
            else
            {
                return $"Drukowanie...";
            }
           
        }
    }
}
