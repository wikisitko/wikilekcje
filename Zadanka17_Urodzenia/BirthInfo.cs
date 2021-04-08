using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zadanka17_Urodzenia
{
    //class BirthInfoComparer : IComparer<BirthInfo>
    //{
    //    public int Compare([AllowNull] BirthInfo x, [AllowNull] BirthInfo y)
    //    {
    //        return y.Count.CompareTo(x.Count);
    //    }
    //}
    class BirthInfo : IComparable<BirthInfo>
    {
        private int period;
        private string mothersAge;
        private int count;

        public BirthInfo(int period, string mothersAge, int count)
        {
            this.period = period;
            this.mothersAge = mothersAge;
            this.count = count;
        }

        public int Period { get => period; set => period = value; }
        public string MothersAge { get => mothersAge; set => mothersAge = value; }
        public int Count { get => count; set => count = value; }

        public int CompareTo([AllowNull] BirthInfo other)
        {
            return count.CompareTo(other.count);
        }

        public override string ToString()
        {
            return $"{period}, {mothersAge}, {count}";
        }
    }
}
