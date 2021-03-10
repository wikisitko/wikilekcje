using System;
using System.Collections.Generic;
using System.Text;

namespace FunkcjeRozszerzajaceNullable_Lekcja
{
    static class ListExtension
    {
        public static void Show(this List<int> lista)
        {
            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
