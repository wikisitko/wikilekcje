using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka14_KursZlota
{
    static class ListExtension
    {
        public static void Pokaz(this List<KursZlota> kursy)
        {
            foreach (var item in kursy)
            {
                Console.WriteLine(item);
            }
        }
    }
}
