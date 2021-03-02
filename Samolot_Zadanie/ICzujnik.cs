using System;
using System.Collections.Generic;
using System.Text;

namespace Samolot_Zadanie
{
    public interface ICzujnik
    {
        double dopuszczalnaTemp();
        double temp();
        bool Alarm()
        {
            if (dopuszczalnaTemp() < temp())
            {
                return true;
            }
            return false;
        }

}
}
