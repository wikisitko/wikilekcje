using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy_Lekcja
{
    //nazewnictwo -> I + jakas nazwa z duzej litery
    interface IZapis
    {
        void ZapiszCSV(string plik);
        void ZapiszXML(string plik);
    }
}
