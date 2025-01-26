using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_c_1.Q1
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }
        public Range(T m, T n)
        {
            Min = m;
            Max = n;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            return Convert.ToDouble(Max) - Convert.ToDouble(Min);
        }
    }
}
