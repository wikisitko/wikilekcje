using System;
using System.Collections.Generic;
using System.Text;

namespace BazyRelacje_Lekcja2
{
    public static class ListExtension
    {
        public static string ElementsToString<T>(this IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(item + ",");
            }
            return sb.ToString();
        }
    }
}
