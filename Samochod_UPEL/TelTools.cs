using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod_UPEL
{
    class TelTools
    {
        //public static bool PoprawnyTel(string tel)
        //{
        //    if (tel.Length != 9)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        foreach (var znak in tel)
        //        {
        //            if (!Char.IsDigit(znak))
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }

        //}

        public static bool PoprawnyTel(string tel)
        {
            if (tel.Length != 9)
            {
                return false;
            }
            else
            {
                try
                {
                    int a = int.Parse(tel);
                    return true;
                }
                catch(FormatException e)
                {
                    return false;
                }
            }

        }
    }
}
